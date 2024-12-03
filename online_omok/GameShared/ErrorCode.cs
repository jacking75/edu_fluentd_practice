﻿public enum ErrorCode
{
	None = 0,

	// Hive Server Error 1 ~ 99
	HiveTokenFail = 1,
	HiveTokenException = 2,
	HiveTokenExpired = 3,
	HiveTokenInvalid = 4,
	HiveTokenMismatch = 5,
	HiveVerifyTokenFailException = 6,
	HiveCreateTokenFail = 7,
	HiveCreateTokenException = 8,
	HiveCreateTokenFailAlreadyExist = 9,
	HiveCreateTokenFailInsertFail = 10,
	HiveCreateTokenFailInsertException = 11,
	HiveTokenNotFound = 12,

	HiveCreateAccountFail = 13,
	HiveCreateAccountException = 14,
	HiveSaveTokenFail = 15,
	HiveSaveTokenException = 16,
	HiveLoginFailUserNotFound = 17,
	HiveLoginFailPasswordInvalid = 18,
	HiveLoginFailException = 19,
	HiveSelectFailException = 20,
	HiveUpdateFailException = 21,
	HiveInsertFailException = 22,
	HiveVerifyTokenFail = 23,

	// Server Error 100 ~ 200

	UnhandledException = 100,
	MatchServerInternalError = 101,
	MatchServerInternalException = 102,
	ServerInternalError = 103,
	ServerInternalException = 104,


	// Middleware Error 200 ~

	BearerTokenNotFound = 200,
	UidNotFound = 201,
	UserLockOccupied = 202,
	BearerTokenExpired = 203,
	BearerTokenInvalid = 204,
	BearerTokenMismatch = 205,
	BearerTokenException = 206,
	UserSessionExpired = 207,

	InvalidAppVersion = 300,
	InvalidMasterDataVersion = 301,


	// Redis Error 500 ~

	RedisGetFail = 500,
	RedisGetException = 501,
	RedisSetFail = 502,
	RedisSetException = 503,
	RedisDeleteFail = 504,
	RedisDeleteException = 505,
	RedisUpdateFail = 506,
	RedisUpdateException = 507,
	RedisLockFail = 508,
	RedisLockException = 509,
	RedisGetAndDeleteFail = 510,
	RedisGetAndDeleteException = 511,
	RedisUnlockFail = 512,
	RedisUnlockException = 513,
	RedisSetEXFail = 514,
	RedisSetEXException = 515,
	RedisSetNXFail = 516,
	RedisSetNXException = 517,
	RedisSetRangeFail = 518,
	RedisSetRangeException = 519,
	RedisGetRangeFail = 520,
	RedisGetRangeException = 521,

	RedisGetAndSetFail = 530,
	RedisGetAndSetException = 531,
	RedisGetOrSetFail = 532,
	RedisGetOrSetException = 533,


	// Service Error 1000 ~ 

	UserGetFail = 1000,
	UserGetException = 1001,
	UserInsertFail = 1002,
	UserInsertException = 1003,
	UserUpdateFail = 1004,
	UserUpdateException = 1005,
	UserUpdateLastLoginFail = 1006,
	UserUpdateLastLoginException = 1007,
	UserLoginFail = 1008,
	UserLoginException = 1009,
	UserLogoutFail = 1010,
	UserLogoutException = 1011,
	UserCreateSessionFail = 1012,
	UserCreateSessionException = 1013,

	UserDataLoadFail = 1020,
	UserDataLoadException = 1021,
	UserDataLoadFailUserNotFound = 1022,
	UserDataLoadFailItemNotFound = 1023,
	UserDataLoadFailAttendanceNotFound = 1024,
	TemplateLoadFail = 1025,
	TemplateLoadException = 1026,
	TemplateNotFound = 1027,

	MailGetFail = 1050,
	MailGetException = 1051,
	MailSendFail = 1052,
	MailSendException = 1053,
	MailDeleteFail = 1054,
	MailDeleteException = 1055,
	MailReadFail = 1056,
	MailReadFailMailNotFound = 1057,
	MailReadFailAlreadyRead = 1058,
	MailReadException = 1059,
	MailUpdateFail = 1060,
	MailUpdateStatusFail = 1061,
	MailUpdateException = 1062,
	MailUpdateStatusException = 1063,
	MailReceiveFail = 1064,
	MailReceiveFailMailNotFound = 1065,
	MailReceiveFailAlreadyReceived = 1066,
	MailReceiveFailMailExpired = 1067,
	MailReceiveFailItemInsertFail = 1068,
	MailReceiveException = 1069,
	MailDeleteFailNotAllowed = 1070,
	MailReadFailNotAllowed = 1071,
	MailReceiveFailNotAllowed = 1072,

	AttendanceGetFail = 1100,
	AttendanceGetException = 1101,
	AttendanceUpdateFail = 1102,
	AttendanceUpdateException = 1103,
	AttendanceUpdateListFail = 1104,
	AttendanceUpdateListException = 1105,
	AttendanceRewardFail = 1106,
	AttendanceRewardException = 1107,
	AttendanceRewardFailAlreadyReceived = 1108,
	AttendanceRewardFailRewardNotFound = 1109,
	AttendanceCheckFail = 1110,
	AttendanceCheckException = 1111,
	AttendanceCheckFailAlreadyAttended = 1112,
	AttendanceCheckFailNotFound = 1113,
	AttendanceUpdateUserFail = 1114,
	AttendanceUpdateUserException = 1115,

	ItemGetFail = 1150,
	ItemGetException = 1151,
	ItemInsertFail = 1152,
	ItemInsertException = 1153,

	OmokEnterFail = 1200,
	OmokEnterException = 1201,
	OmokEnterFailGameAlreadyStarted = 1202,
	OmokEnterFailUserNotFound = 1203,
	OmokEnterFailOpponentNotInGame = 1204,
	OmokPutFail = 1205,
	OmokPutException = 1206,
	OmokPutFailGameNotFound = 1207,
	OmokPutFailUserNotFound = 1208,
	OmokPutFailNotYourTurn = 1209,
	OmokPutFailAlreadyPut = 1210,
	OmokPutFailGameEnded = 1211,
	OmokPutFailInvalidPosition = 1212,
	OmokPeekFail = 1213,
	OmokPeekException = 1214,
	OmokPeekFailGameNotFound = 1215,
	OmokPeekFailUserNotFound = 1216,
	OmokPeekFailUserNotPlaying = 1217,
	OmokPeekFailNoChange = 1218,
	OmokGetGameFail = 1220,
	OmokGetGameException = 1221,
	OmokGetGameFailGameNotFound = 1222,
	OmokGetGameFailUserNotFound = 1223,
	OmokGetGameFailUserNotPlaying = 1224,
	OmokCheckStonePositionFail = 1225,
	OmokCheckStonePositionException = 1226,
	OmokSaveGameFail = 1227,
	OmokSaveGameException = 1228,

	LoginFail = 1300,
	LogoutFail = 1301,

	MatchCheckException = 1400,
	MatchCheckFailMatchNotFound = 1401,
	MatchCheckFailInvalidStatus = 1402,
	MatchCheckFailUserNotFound = 1403,
	MatchCheckFailGameNotFound = 1404,
	MatchStartFailInvalidStatus = 1405,
	MatchStartFailAlreadyMatching = 1406,
	MatchStartFailMatchServer = 1407,
	MatchStartException = 1408,

	// Db Error 10000 ~ 

	DbUserGetFail = 10000,
	DbUserGetException = 10001,
	DbUserInsertFail = 10002,
	DbUserInsertException = 10003,
	DbUserUpdateFail = 10004,
	DbUserUpdateException = 10005,
	DbUserGetFailUserNotFound = 10006,

	DbMailGetFail = 10050,
	DbMailGetException = 10051,
	DbMailInsertFail = 10052,
	DbMailInsertException = 10053,
	DbMailUpdateFail = 10054,
	DbMailUpdateException = 10055,
	DbMailDeleteFail = 10056,
	DbMailDeleteException = 10057,

	DbAttendanceGetFail = 10100,
	DbAttendanceGetException = 10101,
	DbAttendanceInsertFail = 10102,
	DbAttendanceInsertException = 10103,
	DbAttendanceUpdateFail = 101024,
	DbAttendanceUpdateException = 10105,
	DbAttendanceDeleteFail = 10106,
	DbAttendanceDeleteException = 10107,

	DbItemGetFail = 10150,
	DbItemGetException = 10151,
	DbItemInsertFail = 10152,
	DbItemInsertException = 10153,

	DbGameResultInsertFail = 10200,
	DbGameResultInsertException = 10201,

	// Client Error 20000 ~

	LoginFailInvalidResponse = 20000,
	LoginFailException = 20001,

	RegisterFail = 20002,
	RegisterFailInvalidResponse = 20003,
	RegisterFailException = 20004,

	MailListFailBadRequest = 20005,
	MailListFailInvalidResponse = 20006,
	MailListFailException = 20007,
	MailReadBadRequest = 20008,
	MailReadFailRequest = 20009,
	MailReceiveBadRequest = 20010,
	MailReceiveFailRequest = 20011,
	MailSendBadRequest = 20012,
	MailSendFailRequest = 20013,
	MailDeleteBadRequest = 20014,
	MailDeleteFailRequest = 20015,

	GameMatchDuplicate = 20016,
	MatchServerBadRequest = 20017,
	MatchServerRequestFail = 20018,
	MatchServerRequestException = 20019,
	GameMatchCheckTimeout = 20020,
	GameMatchCheckFailBadRequest = 20021,
	GameMatchCheckException = 20022,
	GameMatchCancelled = 20023,
	GameMatchCheckRequestFail = 20024,


	AttendanceUpdateBadRequest = 20025,

	GameGetFail = 20026,
	GameGetFailGameNotFound = 20027,
	GameGetFailInvalidGameData = 20028,
	GameGetException = 20029,

	GamePeekCancelled = 20030,
	GamePeekFailInvalidData = 20031,
	GamePeekFailInvalidGameData = 20032,
	GamePeekFailInvalidResponse = 20033,
	GamePeekException = 20034,
	GamePeekTimeout = 20035,

	UpdateUserFailBadRequest = 20036,
	UpdateUserException = 20037,

	GetUserInfoException = 20038,
	GetUserInfoFail = 20039,

	GetOmokFail = 20040,
	GetOmokFailInvalidData = 20041,
	GetOmokFailInvalidResponse = 20042,
	GetOmokException = 20043,

	PutOmokFail = 20044,
	PutOmokFailInvalidData = 20045,
	PutOmokFailInvalidResponse = 20046,
	PutOmokException = 20047,

	StartOmokFail = 20048,
	StartOmokFailInvalidData = 20049,
	StartOmokException = 20050,
}