<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\dept;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\group;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\job;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\jobStatus;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\userProb;
use AlibabaCloud\Tea\Model;

class content extends Model
{
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

    /**
     * @description 所在医疗组
     *
     * @var group[]
     */
    public $group;

    /**
     * @description 所在科室
     *
     * @var dept[]
     */
    public $dept;
    protected $_name = [
        'uid'       => 'uid',
        'userName'  => 'userName',
        'job'       => 'job',
        'jobNum'    => 'jobNum',
        'jobStatus' => 'jobStatus',
        'userProb'  => 'userProb',
        'group'     => 'group',
        'dept'      => 'dept',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->group) {
            $res['group'] = [];
            if (null !== $this->group && \is_array($this->group)) {
                $n = 0;
                foreach ($this->group as $item) {
                    $res['group'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dept) {
            $res['dept'] = [];
            if (null !== $this->dept && \is_array($this->dept)) {
                $n = 0;
                foreach ($this->dept as $item) {
                    $res['dept'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['group'])) {
            if (!empty($map['group'])) {
                $model->group = [];
                $n            = 0;
                foreach ($map['group'] as $item) {
                    $model->group[$n++] = null !== $item ? group::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dept'])) {
            if (!empty($map['dept'])) {
                $model->dept = [];
                $n           = 0;
                foreach ($map['dept'] as $item) {
                    $model->dept[$n++] = null !== $item ? dept::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
