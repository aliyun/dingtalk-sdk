<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class ResumePostEventRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 王先生
     *
     * @var string
     */
    public $candidateName;

    /**
     * @description This parameter is required.
     *
     * @example 总裁助理
     *
     * @var string
     */
    public $jobName;

    /**
     * @description This parameter is required.
     *
     * @example 123123
     *
     * @var string
     */
    public $jobOwnerUserId;

    /**
     * @description This parameter is required.
     *
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $mobileResumeUrl;

    /**
     * @description This parameter is required.
     *
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $pcResumeUrl;

    /**
     * @example 3年 | 本科
     *
     * @var string
     */
    public $resumeDesc;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $resumePostTime;
    protected $_name = [
        'candidateName' => 'candidateName',
        'jobName' => 'jobName',
        'jobOwnerUserId' => 'jobOwnerUserId',
        'mobileResumeUrl' => 'mobileResumeUrl',
        'pcResumeUrl' => 'pcResumeUrl',
        'resumeDesc' => 'resumeDesc',
        'resumePostTime' => 'resumePostTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateName) {
            $res['candidateName'] = $this->candidateName;
        }
        if (null !== $this->jobName) {
            $res['jobName'] = $this->jobName;
        }
        if (null !== $this->jobOwnerUserId) {
            $res['jobOwnerUserId'] = $this->jobOwnerUserId;
        }
        if (null !== $this->mobileResumeUrl) {
            $res['mobileResumeUrl'] = $this->mobileResumeUrl;
        }
        if (null !== $this->pcResumeUrl) {
            $res['pcResumeUrl'] = $this->pcResumeUrl;
        }
        if (null !== $this->resumeDesc) {
            $res['resumeDesc'] = $this->resumeDesc;
        }
        if (null !== $this->resumePostTime) {
            $res['resumePostTime'] = $this->resumePostTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ResumePostEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateName'])) {
            $model->candidateName = $map['candidateName'];
        }
        if (isset($map['jobName'])) {
            $model->jobName = $map['jobName'];
        }
        if (isset($map['jobOwnerUserId'])) {
            $model->jobOwnerUserId = $map['jobOwnerUserId'];
        }
        if (isset($map['mobileResumeUrl'])) {
            $model->mobileResumeUrl = $map['mobileResumeUrl'];
        }
        if (isset($map['pcResumeUrl'])) {
            $model->pcResumeUrl = $map['pcResumeUrl'];
        }
        if (isset($map['resumeDesc'])) {
            $model->resumeDesc = $map['resumeDesc'];
        }
        if (isset($map['resumePostTime'])) {
            $model->resumePostTime = $map['resumePostTime'];
        }

        return $model;
    }
}
