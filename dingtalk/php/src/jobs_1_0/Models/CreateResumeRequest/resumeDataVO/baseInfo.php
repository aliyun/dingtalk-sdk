<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\Tea\Model;

class baseInfo extends Model
{
    /**
     * @var int
     */
    public $age;

    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $beginWorkTime;

    /**
     * @var string
     */
    public $birthday;

    /**
     * @var int
     */
    public $candidateBackground;

    /**
     * @var string
     */
    public $dingTalk;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $englishName;

    /**
     * @var string
     */
    public $ethnicity;

    /**
     * @var string
     */
    public $gaduateTime;

    /**
     * @var string
     */
    public $highestAcademic;

    /**
     * @var int
     */
    public $highestEducation;

    /**
     * @var string
     */
    public $identify;

    /**
     * @var string
     */
    public $industry;

    /**
     * @var string
     */
    public $industryCode;

    /**
     * @var string
     */
    public $jobTitle;

    /**
     * @var string
     */
    public $lastSchoolName;

    /**
     * @var int
     */
    public $married;

    /**
     * @var int
     */
    public $mbtiType;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nationality;

    /**
     * @var string
     */
    public $nativePlace;

    /**
     * @var string
     */
    public $nativePlaceCode;

    /**
     * @var string
     */
    public $nowLocation;

    /**
     * @var string
     */
    public $nowLocationCode;

    /**
     * @var string
     */
    public $parentIndustry;

    /**
     * @var string
     */
    public $parentIndustryCode;

    /**
     * @var string
     */
    public $personalHonor;

    /**
     * @var string[]
     */
    public $personalUrls;

    /**
     * @var string
     */
    public $phoneNum;

    /**
     * @var int
     */
    public $politicalStatus;

    /**
     * @var string
     */
    public $qq;

    /**
     * @var int
     */
    public $realAvatar;

    /**
     * @var string
     */
    public $selfEvaluation;

    /**
     * @var int
     */
    public $sex;

    /**
     * @var string
     */
    public $skillSummary;

    /**
     * @var string
     */
    public $stateCode;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $virtualPhoneNum;

    /**
     * @var string
     */
    public $weChat;

    /**
     * @var string
     */
    public $weibo;

    /**
     * @var int
     */
    public $workingYears;
    protected $_name = [
        'age'                 => 'age',
        'avatar'              => 'avatar',
        'beginWorkTime'       => 'beginWorkTime',
        'birthday'            => 'birthday',
        'candidateBackground' => 'candidateBackground',
        'dingTalk'            => 'dingTalk',
        'email'               => 'email',
        'englishName'         => 'englishName',
        'ethnicity'           => 'ethnicity',
        'gaduateTime'         => 'gaduateTime',
        'highestAcademic'     => 'highestAcademic',
        'highestEducation'    => 'highestEducation',
        'identify'            => 'identify',
        'industry'            => 'industry',
        'industryCode'        => 'industryCode',
        'jobTitle'            => 'jobTitle',
        'lastSchoolName'      => 'lastSchoolName',
        'married'             => 'married',
        'mbtiType'            => 'mbtiType',
        'name'                => 'name',
        'nationality'         => 'nationality',
        'nativePlace'         => 'nativePlace',
        'nativePlaceCode'     => 'nativePlaceCode',
        'nowLocation'         => 'nowLocation',
        'nowLocationCode'     => 'nowLocationCode',
        'parentIndustry'      => 'parentIndustry',
        'parentIndustryCode'  => 'parentIndustryCode',
        'personalHonor'       => 'personalHonor',
        'personalUrls'        => 'personalUrls',
        'phoneNum'            => 'phoneNum',
        'politicalStatus'     => 'politicalStatus',
        'qq'                  => 'qq',
        'realAvatar'          => 'realAvatar',
        'selfEvaluation'      => 'selfEvaluation',
        'sex'                 => 'sex',
        'skillSummary'        => 'skillSummary',
        'stateCode'           => 'stateCode',
        'status'              => 'status',
        'virtualPhoneNum'     => 'virtualPhoneNum',
        'weChat'              => 'weChat',
        'weibo'               => 'weibo',
        'workingYears'        => 'workingYears',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->age) {
            $res['age'] = $this->age;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->beginWorkTime) {
            $res['beginWorkTime'] = $this->beginWorkTime;
        }
        if (null !== $this->birthday) {
            $res['birthday'] = $this->birthday;
        }
        if (null !== $this->candidateBackground) {
            $res['candidateBackground'] = $this->candidateBackground;
        }
        if (null !== $this->dingTalk) {
            $res['dingTalk'] = $this->dingTalk;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->englishName) {
            $res['englishName'] = $this->englishName;
        }
        if (null !== $this->ethnicity) {
            $res['ethnicity'] = $this->ethnicity;
        }
        if (null !== $this->gaduateTime) {
            $res['gaduateTime'] = $this->gaduateTime;
        }
        if (null !== $this->highestAcademic) {
            $res['highestAcademic'] = $this->highestAcademic;
        }
        if (null !== $this->highestEducation) {
            $res['highestEducation'] = $this->highestEducation;
        }
        if (null !== $this->identify) {
            $res['identify'] = $this->identify;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->jobTitle) {
            $res['jobTitle'] = $this->jobTitle;
        }
        if (null !== $this->lastSchoolName) {
            $res['lastSchoolName'] = $this->lastSchoolName;
        }
        if (null !== $this->married) {
            $res['married'] = $this->married;
        }
        if (null !== $this->mbtiType) {
            $res['mbtiType'] = $this->mbtiType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nationality) {
            $res['nationality'] = $this->nationality;
        }
        if (null !== $this->nativePlace) {
            $res['nativePlace'] = $this->nativePlace;
        }
        if (null !== $this->nativePlaceCode) {
            $res['nativePlaceCode'] = $this->nativePlaceCode;
        }
        if (null !== $this->nowLocation) {
            $res['nowLocation'] = $this->nowLocation;
        }
        if (null !== $this->nowLocationCode) {
            $res['nowLocationCode'] = $this->nowLocationCode;
        }
        if (null !== $this->parentIndustry) {
            $res['parentIndustry'] = $this->parentIndustry;
        }
        if (null !== $this->parentIndustryCode) {
            $res['parentIndustryCode'] = $this->parentIndustryCode;
        }
        if (null !== $this->personalHonor) {
            $res['personalHonor'] = $this->personalHonor;
        }
        if (null !== $this->personalUrls) {
            $res['personalUrls'] = $this->personalUrls;
        }
        if (null !== $this->phoneNum) {
            $res['phoneNum'] = $this->phoneNum;
        }
        if (null !== $this->politicalStatus) {
            $res['politicalStatus'] = $this->politicalStatus;
        }
        if (null !== $this->qq) {
            $res['qq'] = $this->qq;
        }
        if (null !== $this->realAvatar) {
            $res['realAvatar'] = $this->realAvatar;
        }
        if (null !== $this->selfEvaluation) {
            $res['selfEvaluation'] = $this->selfEvaluation;
        }
        if (null !== $this->sex) {
            $res['sex'] = $this->sex;
        }
        if (null !== $this->skillSummary) {
            $res['skillSummary'] = $this->skillSummary;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->virtualPhoneNum) {
            $res['virtualPhoneNum'] = $this->virtualPhoneNum;
        }
        if (null !== $this->weChat) {
            $res['weChat'] = $this->weChat;
        }
        if (null !== $this->weibo) {
            $res['weibo'] = $this->weibo;
        }
        if (null !== $this->workingYears) {
            $res['workingYears'] = $this->workingYears;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return baseInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['age'])) {
            $model->age = $map['age'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['beginWorkTime'])) {
            $model->beginWorkTime = $map['beginWorkTime'];
        }
        if (isset($map['birthday'])) {
            $model->birthday = $map['birthday'];
        }
        if (isset($map['candidateBackground'])) {
            $model->candidateBackground = $map['candidateBackground'];
        }
        if (isset($map['dingTalk'])) {
            $model->dingTalk = $map['dingTalk'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['englishName'])) {
            $model->englishName = $map['englishName'];
        }
        if (isset($map['ethnicity'])) {
            $model->ethnicity = $map['ethnicity'];
        }
        if (isset($map['gaduateTime'])) {
            $model->gaduateTime = $map['gaduateTime'];
        }
        if (isset($map['highestAcademic'])) {
            $model->highestAcademic = $map['highestAcademic'];
        }
        if (isset($map['highestEducation'])) {
            $model->highestEducation = $map['highestEducation'];
        }
        if (isset($map['identify'])) {
            $model->identify = $map['identify'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['jobTitle'])) {
            $model->jobTitle = $map['jobTitle'];
        }
        if (isset($map['lastSchoolName'])) {
            $model->lastSchoolName = $map['lastSchoolName'];
        }
        if (isset($map['married'])) {
            $model->married = $map['married'];
        }
        if (isset($map['mbtiType'])) {
            $model->mbtiType = $map['mbtiType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nationality'])) {
            $model->nationality = $map['nationality'];
        }
        if (isset($map['nativePlace'])) {
            $model->nativePlace = $map['nativePlace'];
        }
        if (isset($map['nativePlaceCode'])) {
            $model->nativePlaceCode = $map['nativePlaceCode'];
        }
        if (isset($map['nowLocation'])) {
            $model->nowLocation = $map['nowLocation'];
        }
        if (isset($map['nowLocationCode'])) {
            $model->nowLocationCode = $map['nowLocationCode'];
        }
        if (isset($map['parentIndustry'])) {
            $model->parentIndustry = $map['parentIndustry'];
        }
        if (isset($map['parentIndustryCode'])) {
            $model->parentIndustryCode = $map['parentIndustryCode'];
        }
        if (isset($map['personalHonor'])) {
            $model->personalHonor = $map['personalHonor'];
        }
        if (isset($map['personalUrls'])) {
            if (!empty($map['personalUrls'])) {
                $model->personalUrls = $map['personalUrls'];
            }
        }
        if (isset($map['phoneNum'])) {
            $model->phoneNum = $map['phoneNum'];
        }
        if (isset($map['politicalStatus'])) {
            $model->politicalStatus = $map['politicalStatus'];
        }
        if (isset($map['qq'])) {
            $model->qq = $map['qq'];
        }
        if (isset($map['realAvatar'])) {
            $model->realAvatar = $map['realAvatar'];
        }
        if (isset($map['selfEvaluation'])) {
            $model->selfEvaluation = $map['selfEvaluation'];
        }
        if (isset($map['sex'])) {
            $model->sex = $map['sex'];
        }
        if (isset($map['skillSummary'])) {
            $model->skillSummary = $map['skillSummary'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['virtualPhoneNum'])) {
            $model->virtualPhoneNum = $map['virtualPhoneNum'];
        }
        if (isset($map['weChat'])) {
            $model->weChat = $map['weChat'];
        }
        if (isset($map['weibo'])) {
            $model->weibo = $map['weibo'];
        }
        if (isset($map['workingYears'])) {
            $model->workingYears = $map['workingYears'];
        }

        return $model;
    }
}
