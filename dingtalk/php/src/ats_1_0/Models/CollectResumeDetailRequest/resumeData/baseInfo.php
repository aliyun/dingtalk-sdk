<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class baseInfo extends Model
{
    /**
     * @description 年龄
     *
     * @var int
     */
    public $age;

    /**
     * @description 头像cdn地址，http链接
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 初次工作时间
     *
     * @var string
     */
    public $beginWorkTime;

    /**
     * @description 生日
     *
     * @var string
     */
    public $birthday;

    /**
     * @description 邮箱地址
     *
     * @var string
     */
    public $email;

    /**
     * @description 英文名称
     *
     * @var string
     */
    public $englishName;

    /**
     * @description 毕业时间
     *
     * @var string
     */
    public $graduateTime;

    /**
     * @description 最高学历
     *
     * @var int
     */
    public $highestEducation;

    /**
     * @description 当前工作职位名称
     *
     * @var string
     */
    public $jobTitle;

    /**
     * @description 最高学历毕业院校名称
     *
     * @var string
     */
    public $lastSchoolName;

    /**
     * @description 婚姻状况
     *
     * @var int
     */
    public $married;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 籍贯地址
     *
     * @var string
     */
    public $nativePlace;

    /**
     * @description 现居住地址
     *
     * @var string
     */
    public $nowLocation;

    /**
     * @description 个人荣誉
     *
     * @var string
     */
    public $personalHonor;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $phoneNum;

    /**
     * @description 政治面貌
     *
     * @var int
     */
    public $politicalStatus;

    /**
     * @description 自我评价
     *
     * @var string
     */
    public $selfEvaluation;

    /**
     * @description 性别
     *
     * @var int
     */
    public $sex;

    /**
     * @description 虚拟手机号
     *
     * @var string
     */
    public $virtualPhoneNum;

    /**
     * @description 工作年限
     *
     * @var int
     */
    public $workingYears;
    protected $_name = [
        'age'              => 'age',
        'avatar'           => 'avatar',
        'beginWorkTime'    => 'beginWorkTime',
        'birthday'         => 'birthday',
        'email'            => 'email',
        'englishName'      => 'englishName',
        'graduateTime'     => 'graduateTime',
        'highestEducation' => 'highestEducation',
        'jobTitle'         => 'jobTitle',
        'lastSchoolName'   => 'lastSchoolName',
        'married'          => 'married',
        'name'             => 'name',
        'nativePlace'      => 'nativePlace',
        'nowLocation'      => 'nowLocation',
        'personalHonor'    => 'personalHonor',
        'phoneNum'         => 'phoneNum',
        'politicalStatus'  => 'politicalStatus',
        'selfEvaluation'   => 'selfEvaluation',
        'sex'              => 'sex',
        'virtualPhoneNum'  => 'virtualPhoneNum',
        'workingYears'     => 'workingYears',
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
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->englishName) {
            $res['englishName'] = $this->englishName;
        }
        if (null !== $this->graduateTime) {
            $res['graduateTime'] = $this->graduateTime;
        }
        if (null !== $this->highestEducation) {
            $res['highestEducation'] = $this->highestEducation;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nativePlace) {
            $res['nativePlace'] = $this->nativePlace;
        }
        if (null !== $this->nowLocation) {
            $res['nowLocation'] = $this->nowLocation;
        }
        if (null !== $this->personalHonor) {
            $res['personalHonor'] = $this->personalHonor;
        }
        if (null !== $this->phoneNum) {
            $res['phoneNum'] = $this->phoneNum;
        }
        if (null !== $this->politicalStatus) {
            $res['politicalStatus'] = $this->politicalStatus;
        }
        if (null !== $this->selfEvaluation) {
            $res['selfEvaluation'] = $this->selfEvaluation;
        }
        if (null !== $this->sex) {
            $res['sex'] = $this->sex;
        }
        if (null !== $this->virtualPhoneNum) {
            $res['virtualPhoneNum'] = $this->virtualPhoneNum;
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
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['englishName'])) {
            $model->englishName = $map['englishName'];
        }
        if (isset($map['graduateTime'])) {
            $model->graduateTime = $map['graduateTime'];
        }
        if (isset($map['highestEducation'])) {
            $model->highestEducation = $map['highestEducation'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nativePlace'])) {
            $model->nativePlace = $map['nativePlace'];
        }
        if (isset($map['nowLocation'])) {
            $model->nowLocation = $map['nowLocation'];
        }
        if (isset($map['personalHonor'])) {
            $model->personalHonor = $map['personalHonor'];
        }
        if (isset($map['phoneNum'])) {
            $model->phoneNum = $map['phoneNum'];
        }
        if (isset($map['politicalStatus'])) {
            $model->politicalStatus = $map['politicalStatus'];
        }
        if (isset($map['selfEvaluation'])) {
            $model->selfEvaluation = $map['selfEvaluation'];
        }
        if (isset($map['sex'])) {
            $model->sex = $map['sex'];
        }
        if (isset($map['virtualPhoneNum'])) {
            $model->virtualPhoneNum = $map['virtualPhoneNum'];
        }
        if (isset($map['workingYears'])) {
            $model->workingYears = $map['workingYears'];
        }

        return $model;
    }
}
