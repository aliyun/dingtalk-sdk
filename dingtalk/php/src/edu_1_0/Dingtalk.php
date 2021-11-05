<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRoleMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRoleMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request
     *
     * @return GetRemoteClassCourseResponse
     */
    public function getRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRemoteClassCourseHeaders([]);

        return $this->getRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request
     * @param GetRemoteClassCourseHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRemoteClassCourseResponse
     */
    public function getRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRemoteClassCourseResponse::fromMap($this->doROARequest('GetRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/remoteClasses/courses/' . $courseCode . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryUniversityCourseGroupRequest $request
     *
     * @return QueryUniversityCourseGroupResponse
     */
    public function queryUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUniversityCourseGroupHeaders([]);

        return $this->queryUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUniversityCourseGroupRequest $request
     * @param QueryUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryUniversityCourseGroupResponse
     */
    public function queryUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->courseGroupCode)) {
            @$query['courseGroupCode'] = $request->courseGroupCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryUniversityCourseGroupResponse::fromMap($this->doROARequest('QueryUniversityCourseGroup', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/universities/courseGroups', 'json', $req, $runtime));
    }

    /**
     * @param QueryStatisticsDataRequest $request
     *
     * @return QueryStatisticsDataResponse
     */
    public function queryStatisticsData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStatisticsDataHeaders([]);

        return $this->queryStatisticsDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryStatisticsDataRequest $request
     * @param QueryStatisticsDataHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryStatisticsDataResponse
     */
    public function queryStatisticsDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->sectionIndexList)) {
            @$body['sectionIndexList'] = $request->sectionIndexList;
        }
        if (!Utils::isUnset($request->teacherUserIds)) {
            @$body['teacherUserIds'] = $request->teacherUserIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryStatisticsDataResponse::fromMap($this->doROARequest('QueryStatisticsData', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/classes/schedules/statisticData/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllSubjectsFromClassScheduleRequest $request
     *
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public function queryAllSubjectsFromClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllSubjectsFromClassScheduleHeaders([]);

        return $this->queryAllSubjectsFromClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllSubjectsFromClassScheduleRequest $tmpReq
     * @param QueryAllSubjectsFromClassScheduleHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public function queryAllSubjectsFromClassScheduleWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryAllSubjectsFromClassScheduleShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->classIds)) {
            $request->classIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->classIds, 'classIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->classIdsShrink)) {
            @$query['classIds'] = $request->classIdsShrink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->periodCode)) {
            @$query['periodCode'] = $request->periodCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryAllSubjectsFromClassScheduleResponse::fromMap($this->doROARequest('QueryAllSubjectsFromClassSchedule', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/subjects/instances', 'json', $req, $runtime));
    }

    /**
     * @param QueryClassScheduleConfigRequest $request
     *
     * @return QueryClassScheduleConfigResponse
     */
    public function queryClassScheduleConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleConfigHeaders([]);

        return $this->queryClassScheduleConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleConfigRequest $tmpReq
     * @param QueryClassScheduleConfigHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryClassScheduleConfigResponse
     */
    public function queryClassScheduleConfigWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryClassScheduleConfigShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->classIds)) {
            $request->classIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->classIds, 'classIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->classIdsShrink)) {
            @$query['classIds'] = $request->classIdsShrink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryClassScheduleConfigResponse::fromMap($this->doROARequest('QueryClassScheduleConfig', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/schedules/configs', 'json', $req, $runtime));
    }

    /**
     * @return GetDefaultChildResponse
     */
    public function getDefaultChild()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDefaultChildHeaders([]);

        return $this->getDefaultChildWithOptions($headers, $runtime);
    }

    /**
     * @param GetDefaultChildHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDefaultChildResponse
     */
    public function getDefaultChildWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetDefaultChildResponse::fromMap($this->doROARequest('GetDefaultChild', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/defaultChildren', 'json', $req, $runtime));
    }

    /**
     * @param GetOpenCoursesRequest $request
     *
     * @return GetOpenCoursesResponse
     */
    public function getOpenCourses($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCoursesHeaders([]);

        return $this->getOpenCoursesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOpenCoursesRequest $request
     * @param GetOpenCoursesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetOpenCoursesResponse
     */
    public function getOpenCoursesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOpenCoursesResponse::fromMap($this->doROARequest('GetOpenCourses', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/openCourses', 'json', $req, $runtime));
    }

    /**
     * @param CourseSchedulingComplimentNoticeRequest $request
     *
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public function courseSchedulingComplimentNotice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CourseSchedulingComplimentNoticeHeaders([]);

        return $this->courseSchedulingComplimentNoticeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CourseSchedulingComplimentNoticeRequest $request
     * @param CourseSchedulingComplimentNoticeHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public function courseSchedulingComplimentNoticeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CourseSchedulingComplimentNoticeResponse::fromMap($this->doROARequest('CourseSchedulingComplimentNotice', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/schedules/finishNotify', 'json', $req, $runtime));
    }

    /**
     * @param DeleteUniversityCourseGroupRequest $request
     *
     * @return DeleteUniversityCourseGroupResponse
     */
    public function deleteUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityCourseGroupHeaders([]);

        return $this->deleteUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteUniversityCourseGroupRequest $request
     * @param DeleteUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return DeleteUniversityCourseGroupResponse
     */
    public function deleteUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->courseGroupCode)) {
            @$query['courseGroupCode'] = $request->courseGroupCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteUniversityCourseGroupResponse::fromMap($this->doROARequest('DeleteUniversityCourseGroup', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/universities/courseGroups', 'json', $req, $runtime));
    }

    /**
     * @param BatchCreateRequest $request
     *
     * @return BatchCreateResponse
     */
    public function batchCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateHeaders([]);

        return $this->batchCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchCreateRequest $request
     * @param BatchCreateHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return BatchCreateResponse
     */
    public function batchCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            @$body['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->data)) {
            @$body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->identifier)) {
            @$body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->sourceType)) {
            @$body['sourceType'] = $request->sourceType;
        }
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->jsVersion)) {
            @$body['jsVersion'] = $request->jsVersion;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchCreateResponse::fromMap($this->doROARequest('BatchCreate', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/cards', 'json', $req, $runtime));
    }

    /**
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request
     *
     * @return InitCoursesOfClassResponse
     */
    public function initCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitCoursesOfClassHeaders([]);

        return $this->initCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request
     * @param InitCoursesOfClassHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return InitCoursesOfClassResponse
     */
    public function initCoursesOfClassWithOptions($classId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courses)) {
            @$body['courses'] = $request->courses;
        }
        if (!Utils::isUnset($request->sectionConfig)) {
            @$body['sectionConfig'] = $request->sectionConfig;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InitCoursesOfClassResponse::fromMap($this->doROARequest('InitCoursesOfClass', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/classes/' . $classId . '/courses/init', 'json', $req, $runtime));
    }

    /**
     * @param CreateInviteUrlRequest $request
     *
     * @return CreateInviteUrlResponse
     */
    public function createInviteUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInviteUrlHeaders([]);

        return $this->createInviteUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInviteUrlRequest $request
     * @param CreateInviteUrlHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateInviteUrlResponse
     */
    public function createInviteUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            @$body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->authCode)) {
            @$body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->targetOperator)) {
            @$body['targetOperator'] = $request->targetOperator;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateInviteUrlResponse::fromMap($this->doROARequest('CreateInviteUrl', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/remoteClasses/orgRelations/inviteUrls', 'json', $req, $runtime));
    }

    /**
     * @param string            $deptId
     * @param DeleteDeptRequest $request
     *
     * @return DeleteDeptResponse
     */
    public function deleteDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeptHeaders([]);

        return $this->deleteDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string            $deptId
     * @param DeleteDeptRequest $request
     * @param DeleteDeptHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteDeptResponse
     */
    public function deleteDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteDeptResponse::fromMap($this->doROARequest('DeleteDept', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/depts/' . $deptId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request
     *
     * @return DeleteGuardianResponse
     */
    public function deleteGuardian($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGuardianHeaders([]);

        return $this->deleteGuardianWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request
     * @param DeleteGuardianHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteGuardianResponse
     */
    public function deleteGuardianWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->stuId)) {
            @$query['stuId'] = $request->stuId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteGuardianResponse::fromMap($this->doROARequest('DeleteGuardian', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/classes/' . $classId . '/guardians/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param InsertSectionConfigRequest $request
     *
     * @return InsertSectionConfigResponse
     */
    public function insertSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertSectionConfigHeaders([]);

        return $this->insertSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InsertSectionConfigRequest $request
     * @param InsertSectionConfigHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return InsertSectionConfigResponse
     */
    public function insertSectionConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->sectionModels)) {
            @$body['sectionModels'] = $request->sectionModels;
        }
        if (!Utils::isUnset($request->start)) {
            @$body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->end)) {
            @$body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->scheduleName)) {
            @$body['scheduleName'] = $request->scheduleName;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InsertSectionConfigResponse::fromMap($this->doROARequest('InsertSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/schedules/configs', 'json', $req, $runtime));
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request
     *
     * @return DeleteTeacherResponse
     */
    public function deleteTeacher($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeacherHeaders([]);

        return $this->deleteTeacherWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request
     * @param DeleteTeacherHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteTeacherResponse
     */
    public function deleteTeacherWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->adviser)) {
            @$query['adviser'] = $request->adviser;
        }
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteTeacherResponse::fromMap($this->doROARequest('DeleteTeacher', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/classes/' . $classId . '/teachers/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryDeviceListByCorpIdRequest $request
     *
     * @return QueryDeviceListByCorpIdResponse
     */
    public function queryDeviceListByCorpId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceListByCorpIdHeaders([]);

        return $this->queryDeviceListByCorpIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDeviceListByCorpIdRequest $request
     * @param QueryDeviceListByCorpIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryDeviceListByCorpIdResponse
     */
    public function queryDeviceListByCorpIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryDeviceListByCorpIdResponse::fromMap($this->doROARequest('QueryDeviceListByCorpId', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/remoteClasses/devices', 'json', $req, $runtime));
    }

    /**
     * @param DeleteDeviceOrgRequest $request
     *
     * @return DeleteDeviceOrgResponse
     */
    public function deleteDeviceOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceOrgHeaders([]);

        return $this->deleteDeviceOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteDeviceOrgRequest $request
     * @param DeleteDeviceOrgHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteDeviceOrgResponse
     */
    public function deleteDeviceOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceCode)) {
            @$query['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->authCode)) {
            @$query['authCode'] = $request->authCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteDeviceOrgResponse::fromMap($this->doROARequest('DeleteDeviceOrg', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/remoteClasses/deviceOrgs', 'json', $req, $runtime));
    }

    /**
     * @param UpdateUniversityCourseGroupRequest $request
     *
     * @return UpdateUniversityCourseGroupResponse
     */
    public function updateUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUniversityCourseGroupHeaders([]);

        return $this->updateUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateUniversityCourseGroupRequest $request
     * @param UpdateUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return UpdateUniversityCourseGroupResponse
     */
    public function updateUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->courseGroupCode)) {
            @$body['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->courseGroupIntroduce)) {
            @$body['courseGroupIntroduce'] = $request->courseGroupIntroduce;
        }
        if (!Utils::isUnset($request->courseGroupName)) {
            @$body['courseGroupName'] = $request->courseGroupName;
        }
        if (!Utils::isUnset($request->courserGroupItemModels)) {
            @$body['courserGroupItemModels'] = $request->courserGroupItemModels;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateUniversityCourseGroupResponse::fromMap($this->doROARequest('UpdateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/edu/universities/courseGroups', 'json', $req, $runtime));
    }

    /**
     * @param BatchOrgCreateHWRequest $request
     *
     * @return BatchOrgCreateHWResponse
     */
    public function batchOrgCreateHW($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchOrgCreateHWHeaders([]);

        return $this->batchOrgCreateHWWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchOrgCreateHWRequest $request
     * @param BatchOrgCreateHWHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return BatchOrgCreateHWResponse
     */
    public function batchOrgCreateHWWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->hwMedia)) {
            @$body['hwMedia'] = $request->hwMedia;
        }
        if (!Utils::isUnset($request->hwContent)) {
            @$body['hwContent'] = $request->hwContent;
        }
        if (!Utils::isUnset($request->hwTitle)) {
            @$body['hwTitle'] = $request->hwTitle;
        }
        if (!Utils::isUnset($request->courseName)) {
            @$body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->hwPhoto)) {
            @$body['hwPhoto'] = $request->hwPhoto;
        }
        if (!Utils::isUnset($request->hwVideo)) {
            @$body['hwVideo'] = $request->hwVideo;
        }
        if (!Utils::isUnset($request->teacherName)) {
            @$body['teacherName'] = $request->teacherName;
        }
        if (!Utils::isUnset($request->teacherUserId)) {
            @$body['teacherUserId'] = $request->teacherUserId;
        }
        if (!Utils::isUnset($request->identifier)) {
            @$body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->attributes)) {
            @$body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->targetRole)) {
            @$body['targetRole'] = $request->targetRole;
        }
        if (!Utils::isUnset($request->bizCode)) {
            @$body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->scheduledRelease)) {
            @$body['scheduledRelease'] = $request->scheduledRelease;
        }
        if (!Utils::isUnset($request->scheduledTime)) {
            @$body['scheduledTime'] = $request->scheduledTime;
        }
        if (!Utils::isUnset($request->hwDeadlineOpen)) {
            @$body['hwDeadlineOpen'] = $request->hwDeadlineOpen;
        }
        if (!Utils::isUnset($request->hwDeadline)) {
            @$body['hwDeadline'] = $request->hwDeadline;
        }
        if (!Utils::isUnset($request->hwType)) {
            @$body['hwType'] = $request->hwType;
        }
        if (!Utils::isUnset($request->openSelectItemList)) {
            @$body['openSelectItemList'] = $request->openSelectItemList;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchOrgCreateHWResponse::fromMap($this->doROARequest('BatchOrgCreateHW', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/homeworks', 'json', $req, $runtime));
    }

    /**
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request
     *
     * @return DeleteRemoteClassCourseResponse
     */
    public function deleteRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRemoteClassCourseHeaders([]);

        return $this->deleteRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request
     * @param DeleteRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteRemoteClassCourseResponse
     */
    public function deleteRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCode)) {
            @$query['authCode'] = $request->authCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteRemoteClassCourseResponse::fromMap($this->doROARequest('DeleteRemoteClassCourse', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/remoteClasses/courses/' . $courseCode . '', 'json', $req, $runtime));
    }

    /**
     * @param CreateCustomDeptRequest $request
     *
     * @return CreateCustomDeptResponse
     */
    public function createCustomDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomDeptHeaders([]);

        return $this->createCustomDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomDeptRequest $request
     * @param CreateCustomDeptHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateCustomDeptResponse
     */
    public function createCustomDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customDept)) {
            @$body['customDept'] = $request->customDept;
        }
        if (!Utils::isUnset($request->superId)) {
            @$body['superId'] = $request->superId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateCustomDeptResponse::fromMap($this->doROARequest('CreateCustomDept', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/customDepts', 'json', $req, $runtime));
    }

    /**
     * @param string $courseId
     *
     * @return GetOpenCourseDetailResponse
     */
    public function getOpenCourseDetail($courseId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCourseDetailHeaders([]);

        return $this->getOpenCourseDetailWithOptions($courseId, $headers, $runtime);
    }

    /**
     * @param string                     $courseId
     * @param GetOpenCourseDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetOpenCourseDetailResponse
     */
    public function getOpenCourseDetailWithOptions($courseId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetOpenCourseDetailResponse::fromMap($this->doROARequest('GetOpenCourseDetail', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/openCourse/' . $courseId . '', 'json', $req, $runtime));
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request
     *
     * @return DeleteStudentResponse
     */
    public function deleteStudent($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteStudentHeaders([]);

        return $this->deleteStudentWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request
     * @param DeleteStudentHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteStudentResponse
     */
    public function deleteStudentWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteStudentResponse::fromMap($this->doROARequest('DeleteStudent', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/classes/' . $classId . '/students/' . $userId . '', 'json', $req, $runtime));
    }

    /**
     * @param QueryClassScheduleByTimeSchoolRequest $request
     *
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public function queryClassScheduleByTimeSchool($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleByTimeSchoolHeaders([]);

        return $this->queryClassScheduleByTimeSchoolWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleByTimeSchoolRequest $request
     * @param QueryClassScheduleByTimeSchoolHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public function queryClassScheduleByTimeSchoolWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryClassScheduleByTimeSchoolResponse::fromMap($this->doROARequest('QueryClassScheduleByTimeSchool', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/schools/classes/courses ', 'json', $req, $runtime));
    }

    /**
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request
     *
     * @return UpdateCoursesOfClassResponse
     */
    public function updateCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCoursesOfClassHeaders([]);

        return $this->updateCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request
     * @param UpdateCoursesOfClassHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateCoursesOfClassResponse
     */
    public function updateCoursesOfClassWithOptions($classId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courses)) {
            @$body['courses'] = $request->courses;
        }
        if (!Utils::isUnset($request->sectionConfig)) {
            @$body['sectionConfig'] = $request->sectionConfig;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateCoursesOfClassResponse::fromMap($this->doROARequest('UpdateCoursesOfClass', 'edu_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/edu/classes/' . $classId . '/courses/schedules', 'json', $req, $runtime));
    }

    /**
     * @param QueryTeachSubjectsRequest $request
     *
     * @return QueryTeachSubjectsResponse
     */
    public function queryTeachSubjects($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTeachSubjectsHeaders([]);

        return $this->queryTeachSubjectsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTeachSubjectsRequest $request
     * @param QueryTeachSubjectsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryTeachSubjectsResponse
     */
    public function queryTeachSubjectsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classIds)) {
            @$query['classIds'] = $request->classIds;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryTeachSubjectsResponse::fromMap($this->doROARequest('QueryTeachSubjects', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/teachers/subjects', 'json', $req, $runtime));
    }

    /**
     * @param CreateSectionConfigRequest $request
     *
     * @return CreateSectionConfigResponse
     */
    public function createSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSectionConfigHeaders([]);

        return $this->createSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSectionConfigRequest $request
     * @param CreateSectionConfigHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateSectionConfigResponse
     */
    public function createSectionConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->sectionConfigs)) {
            @$body['sectionConfigs'] = $request->sectionConfigs;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateSectionConfigResponse::fromMap($this->doROARequest('CreateSectionConfig', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/universities/sectionConfigs', 'json', $req, $runtime));
    }

    /**
     * @return GetShareRolesResponse
     */
    public function getShareRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRolesHeaders([]);

        return $this->getShareRolesWithOptions($headers, $runtime);
    }

    /**
     * @param GetShareRolesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetShareRolesResponse
     */
    public function getShareRolesWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetShareRolesResponse::fromMap($this->doROARequest('GetShareRoles', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/shareRoles', 'json', $req, $runtime));
    }

    /**
     * @param QuerySubjectTeachersRequest $request
     *
     * @return QuerySubjectTeachersResponse
     */
    public function querySubjectTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySubjectTeachersHeaders([]);

        return $this->querySubjectTeachersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySubjectTeachersRequest $request
     * @param QuerySubjectTeachersHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QuerySubjectTeachersResponse
     */
    public function querySubjectTeachersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classIds)) {
            @$query['classIds'] = $request->classIds;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->subjectCode)) {
            @$query['subjectCode'] = $request->subjectCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QuerySubjectTeachersResponse::fromMap($this->doROARequest('QuerySubjectTeachers', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/subjects/teachers', 'json', $req, $runtime));
    }

    /**
     * @param QueryRemoteClassCourseRequest $request
     *
     * @return QueryRemoteClassCourseResponse
     */
    public function queryRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRemoteClassCourseHeaders([]);

        return $this->queryRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRemoteClassCourseRequest $request
     * @param QueryRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryRemoteClassCourseResponse
     */
    public function queryRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryRemoteClassCourseResponse::fromMap($this->doROARequest('QueryRemoteClassCourse', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/remoteClasses/courses', 'json', $req, $runtime));
    }

    /**
     * @param CreatePhysicalClassroomRequest $request
     *
     * @return CreatePhysicalClassroomResponse
     */
    public function createPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePhysicalClassroomHeaders([]);

        return $this->createPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreatePhysicalClassroomRequest $request
     * @param CreatePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreatePhysicalClassroomResponse
     */
    public function createPhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->classroomFloor)) {
            @$body['classroomFloor'] = $request->classroomFloor;
        }
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->classroomBuilding)) {
            @$body['classroomBuilding'] = $request->classroomBuilding;
        }
        if (!Utils::isUnset($request->directBroadcast)) {
            @$body['directBroadcast'] = $request->directBroadcast;
        }
        if (!Utils::isUnset($request->classroomName)) {
            @$body['classroomName'] = $request->classroomName;
        }
        if (!Utils::isUnset($request->classroomCampus)) {
            @$body['classroomCampus'] = $request->classroomCampus;
        }
        if (!Utils::isUnset($request->classroomNumber)) {
            @$body['classroomNumber'] = $request->classroomNumber;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreatePhysicalClassroomResponse::fromMap($this->doROARequest('CreatePhysicalClassroom', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/physicalClassrooms', 'json', $req, $runtime));
    }

    /**
     * @param QueryClassScheduleRequest $request
     *
     * @return QueryClassScheduleResponse
     */
    public function queryClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleHeaders([]);

        return $this->queryClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleRequest $request
     * @param QueryClassScheduleHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryClassScheduleResponse
     */
    public function queryClassScheduleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->subscriberType)) {
            @$query['subscriberType'] = $request->subscriberType;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->subscriberIds)) {
            @$body['subscriberIds'] = $request->subscriberIds;
        }
        if (!Utils::isUnset($request->sectionIndexList)) {
            @$body['sectionIndexList'] = $request->sectionIndexList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryClassScheduleResponse::fromMap($this->doROARequest('QueryClassSchedule', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/classes/schedules/query', 'json', $req, $runtime));
    }

    /**
     * @param DeleteOrgRelationRequest $request
     *
     * @return DeleteOrgRelationResponse
     */
    public function deleteOrgRelation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteOrgRelationHeaders([]);

        return $this->deleteOrgRelationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteOrgRelationRequest $request
     * @param DeleteOrgRelationHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DeleteOrgRelationResponse
     */
    public function deleteOrgRelationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetCorpId)) {
            @$query['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->authCode)) {
            @$query['authCode'] = $request->authCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteOrgRelationResponse::fromMap($this->doROARequest('DeleteOrgRelation', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/remoteClasses/orgRelations', 'json', $req, $runtime));
    }

    /**
     * @param CreateRemoteClassCourseRequest $request
     *
     * @return CreateRemoteClassCourseResponse
     */
    public function createRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRemoteClassCourseHeaders([]);

        return $this->createRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateRemoteClassCourseRequest $request
     * @param CreateRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateRemoteClassCourseResponse
     */
    public function createRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->courseName)) {
            @$body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->teachingParticipant)) {
            @$body['teachingParticipant'] = $request->teachingParticipant;
        }
        if (!Utils::isUnset($request->attendParticipants)) {
            @$body['attendParticipants'] = $request->attendParticipants;
        }
        if (!Utils::isUnset($request->authCode)) {
            @$body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateRemoteClassCourseResponse::fromMap($this->doROARequest('CreateRemoteClassCourse', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/remoteClasses/courses', 'json', $req, $runtime));
    }

    /**
     * @param QueryPhysicalClassroomRequest $request
     *
     * @return QueryPhysicalClassroomResponse
     */
    public function queryPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPhysicalClassroomHeaders([]);

        return $this->queryPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPhysicalClassroomRequest $request
     * @param QueryPhysicalClassroomHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryPhysicalClassroomResponse
     */
    public function queryPhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->classroomId)) {
            @$query['classroomId'] = $request->classroomId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryPhysicalClassroomResponse::fromMap($this->doROARequest('QueryPhysicalClassroom', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/physicalClassrooms', 'json', $req, $runtime));
    }

    /**
     * @param CreateCustomClassRequest $request
     *
     * @return CreateCustomClassResponse
     */
    public function createCustomClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomClassHeaders([]);

        return $this->createCustomClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomClassRequest $request
     * @param CreateCustomClassHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateCustomClassResponse
     */
    public function createCustomClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customClass)) {
            @$body['customClass'] = $request->customClass;
        }
        if (!Utils::isUnset($request->superId)) {
            @$body['superId'] = $request->superId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateCustomClassResponse::fromMap($this->doROARequest('CreateCustomClass', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/customClasses', 'json', $req, $runtime));
    }

    /**
     * @param UpdateRemoteClassCourseRequest $request
     *
     * @return UpdateRemoteClassCourseResponse
     */
    public function updateRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRemoteClassCourseHeaders([]);

        return $this->updateRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRemoteClassCourseRequest $request
     * @param UpdateRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdateRemoteClassCourseResponse
     */
    public function updateRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->courseName)) {
            @$body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->teachingParticipant)) {
            @$body['teachingParticipant'] = $request->teachingParticipant;
        }
        if (!Utils::isUnset($request->attendParticipants)) {
            @$body['attendParticipants'] = $request->attendParticipants;
        }
        if (!Utils::isUnset($request->courseCode)) {
            @$body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->authCode)) {
            @$body['authCode'] = $request->authCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateRemoteClassCourseResponse::fromMap($this->doROARequest('UpdateRemoteClassCourse', 'edu_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/edu/remoteClasses/courses', 'json', $req, $runtime));
    }

    /**
     * @param QueryOrgSecretKeyRequest $request
     *
     * @return QueryOrgSecretKeyResponse
     */
    public function queryOrgSecretKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgSecretKeyHeaders([]);

        return $this->queryOrgSecretKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgSecretKeyRequest $request
     * @param QueryOrgSecretKeyHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryOrgSecretKeyResponse
     */
    public function queryOrgSecretKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isvCode)) {
            @$query['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryOrgSecretKeyResponse::fromMap($this->doROARequest('QueryOrgSecretKey', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/universities/secretKeys', 'json', $req, $runtime));
    }

    /**
     * @param SearchTeachersRequest $request
     *
     * @return SearchTeachersResponse
     */
    public function searchTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTeachersHeaders([]);

        return $this->searchTeachersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchTeachersRequest $request
     * @param SearchTeachersHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchTeachersResponse
     */
    public function searchTeachersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nameKeyword)) {
            @$query['nameKeyword'] = $request->nameKeyword;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchTeachersResponse::fromMap($this->doROARequest('SearchTeachers', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/teachers/search', 'json', $req, $runtime));
    }

    /**
     * @param UpdatePhysicalClassroomRequest $request
     *
     * @return UpdatePhysicalClassroomResponse
     */
    public function updatePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePhysicalClassroomHeaders([]);

        return $this->updatePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdatePhysicalClassroomRequest $request
     * @param UpdatePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdatePhysicalClassroomResponse
     */
    public function updatePhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->classroomFloor)) {
            @$body['classroomFloor'] = $request->classroomFloor;
        }
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->classroomBuilding)) {
            @$body['classroomBuilding'] = $request->classroomBuilding;
        }
        if (!Utils::isUnset($request->directBroadcast)) {
            @$body['directBroadcast'] = $request->directBroadcast;
        }
        if (!Utils::isUnset($request->classroomName)) {
            @$body['classroomName'] = $request->classroomName;
        }
        if (!Utils::isUnset($request->classroomCampus)) {
            @$body['classroomCampus'] = $request->classroomCampus;
        }
        if (!Utils::isUnset($request->classroomNumber)) {
            @$body['classroomNumber'] = $request->classroomNumber;
        }
        if (!Utils::isUnset($request->classroomId)) {
            @$body['classroomId'] = $request->classroomId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdatePhysicalClassroomResponse::fromMap($this->doROARequest('UpdatePhysicalClassroom', 'edu_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/edu/physicalClassrooms', 'json', $req, $runtime));
    }

    /**
     * @param DeletePhysicalClassroomRequest $request
     *
     * @return DeletePhysicalClassroomResponse
     */
    public function deletePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePhysicalClassroomHeaders([]);

        return $this->deletePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeletePhysicalClassroomRequest $request
     * @param DeletePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeletePhysicalClassroomResponse
     */
    public function deletePhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->classroomId)) {
            @$query['classroomId'] = $request->classroomId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeletePhysicalClassroomResponse::fromMap($this->doROARequest('DeletePhysicalClassroom', 'edu_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/edu/physicalClassrooms', 'json', $req, $runtime));
    }

    /**
     * @param QueryOrgRelationListRequest $request
     *
     * @return QueryOrgRelationListResponse
     */
    public function queryOrgRelationList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgRelationListHeaders([]);

        return $this->queryOrgRelationListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgRelationListRequest $request
     * @param QueryOrgRelationListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryOrgRelationListResponse
     */
    public function queryOrgRelationListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            @$query['operator'] = $request->operator;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryOrgRelationListResponse::fromMap($this->doROARequest('QueryOrgRelationList', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/remoteClasses/orgRelations', 'json', $req, $runtime));
    }

    /**
     * @return QueryOrgTypeResponse
     */
    public function queryOrgType()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTypeHeaders([]);

        return $this->queryOrgTypeWithOptions($headers, $runtime);
    }

    /**
     * @param QueryOrgTypeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return QueryOrgTypeResponse
     */
    public function queryOrgTypeWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryOrgTypeResponse::fromMap($this->doROARequest('QueryOrgType', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/orgTypes', 'json', $req, $runtime));
    }

    /**
     * @param CreateUniversityCourseGroupRequest $request
     *
     * @return CreateUniversityCourseGroupResponse
     */
    public function createUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityCourseGroupHeaders([]);

        return $this->createUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateUniversityCourseGroupRequest $request
     * @param CreateUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreateUniversityCourseGroupResponse
     */
    public function createUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->isvCourseGroupCode)) {
            @$body['isvCourseGroupCode'] = $request->isvCourseGroupCode;
        }
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->courseGroupIntroduce)) {
            @$body['courseGroupIntroduce'] = $request->courseGroupIntroduce;
        }
        if (!Utils::isUnset($request->semester)) {
            @$body['semester'] = $request->semester;
        }
        if (!Utils::isUnset($request->subjectName)) {
            @$body['subjectName'] = $request->subjectName;
        }
        if (!Utils::isUnset($request->courseGroupName)) {
            @$body['courseGroupName'] = $request->courseGroupName;
        }
        if (!Utils::isUnset($request->schoolYear)) {
            @$body['schoolYear'] = $request->schoolYear;
        }
        if (!Utils::isUnset($request->periodCode)) {
            @$body['periodCode'] = $request->periodCode;
        }
        if (!Utils::isUnset($request->teacherInfos)) {
            @$body['teacherInfos'] = $request->teacherInfos;
        }
        if (!Utils::isUnset($request->courserGroupItemModels)) {
            @$body['courserGroupItemModels'] = $request->courserGroupItemModels;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateUniversityCourseGroupResponse::fromMap($this->doROARequest('CreateUniversityCourseGroup', 'edu_1.0', 'HTTP', 'POST', 'AK', '/v1.0/edu/universities/courseGroups', 'json', $req, $runtime));
    }

    /**
     * @param string $shareRoleCode
     *
     * @return GetShareRoleMembersResponse
     */
    public function getShareRoleMembers($shareRoleCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRoleMembersHeaders([]);

        return $this->getShareRoleMembersWithOptions($shareRoleCode, $headers, $runtime);
    }

    /**
     * @param string                     $shareRoleCode
     * @param GetShareRoleMembersHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetShareRoleMembersResponse
     */
    public function getShareRoleMembersWithOptions($shareRoleCode, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetShareRoleMembersResponse::fromMap($this->doROARequest('GetShareRoleMembers', 'edu_1.0', 'HTTP', 'GET', 'AK', '/v1.0/edu/shareRoles/' . $shareRoleCode . '/members', 'json', $req, $runtime));
    }
}
