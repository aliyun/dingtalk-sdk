<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponseBody\content\job;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponseBody\content\jobStatus;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponseBody\content\userProb;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 钉钉staffId
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 用户Id
     *
     * @var string
     */
    public $uid;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $userName;

    /**
     * @description 职称标签
     *
     * @var job
     */
    public $job;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNum;

    /**
     * @description 工作状态标签
     *
     * @var jobStatus
     */
    public $jobStatus;

    /**
     * @description 人员属性标签
     *
     * @var userProb
     */
    public $userProb;
    protected $_name = [
        'staffId'   => 'staffId',
        'uid'       => 'uid',
        'userName'  => 'userName',
        'job'       => 'job',
        'jobNum'    => 'jobNum',
        'jobStatus' => 'jobStatus',
        'userProb'  => 'userProb',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->job) {
            $res['job'] = null !== $this->job ? $this->job->toMap() : null;
        }
        if (null !== $this->jobNum) {
            $res['jobNum'] = $this->jobNum;
        }
        if (null !== $this->jobStatus) {
            $res['jobStatus'] = null !== $this->jobStatus ? $this->jobStatus->toMap() : null;
        }
        if (null !== $this->userProb) {
            $res['userProb'] = null !== $this->userProb ? $this->userProb->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['job'])) {
            $model->job = job::fromMap($map['job']);
        }
        if (isset($map['jobNum'])) {
            $model->jobNum = $map['jobNum'];
        }
        if (isset($map['jobStatus'])) {
            $model->jobStatus = jobStatus::fromMap($map['jobStatus']);
        }
        if (isset($map['userProb'])) {
            $model->userProb = userProb::fromMap($map['userProb']);
        }

        return $model;
    }
}
