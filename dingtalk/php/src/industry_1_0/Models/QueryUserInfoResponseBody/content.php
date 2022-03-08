<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\dept;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\group;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\job;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\jobStatus;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\jobStatusList;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content\userProb;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description comments
     *
     * @var string
     */
    public $comments;

    /**
     * @description 所在科室
     *
     * @var dept[]
     */
    public $dept;

    /**
     * @description 所在医疗组
     *
     * @var group[]
     */
    public $group;

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
     * @description 工作状态标签, 已废弃, 请使用jobStatusList字段
     *
     * @var jobStatus
     */
    public $jobStatus;

    /**
     * @description 工作状态标签
     *
     * @var jobStatusList[]
     */
    public $jobStatusList;

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
     * @description 人员属性标签
     *
     * @var userProb
     */
    public $userProb;
    protected $_name = [
        'comments'      => 'comments',
        'dept'          => 'dept',
        'group'         => 'group',
        'job'           => 'job',
        'jobNum'        => 'jobNum',
        'jobStatus'     => 'jobStatus',
        'jobStatusList' => 'jobStatusList',
        'uid'           => 'uid',
        'userName'      => 'userName',
        'userProb'      => 'userProb',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comments) {
            $res['comments'] = $this->comments;
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
        if (null !== $this->group) {
            $res['group'] = [];
            if (null !== $this->group && \is_array($this->group)) {
                $n = 0;
                foreach ($this->group as $item) {
                    $res['group'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->jobStatusList) {
            $res['jobStatusList'] = [];
            if (null !== $this->jobStatusList && \is_array($this->jobStatusList)) {
                $n = 0;
                foreach ($this->jobStatusList as $item) {
                    $res['jobStatusList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
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
        if (isset($map['comments'])) {
            $model->comments = $map['comments'];
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
        if (isset($map['group'])) {
            if (!empty($map['group'])) {
                $model->group = [];
                $n            = 0;
                foreach ($map['group'] as $item) {
                    $model->group[$n++] = null !== $item ? group::fromMap($item) : $item;
                }
            }
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
        if (isset($map['jobStatusList'])) {
            if (!empty($map['jobStatusList'])) {
                $model->jobStatusList = [];
                $n                    = 0;
                foreach ($map['jobStatusList'] as $item) {
                    $model->jobStatusList[$n++] = null !== $item ? jobStatusList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['userProb'])) {
            $model->userProb = userProb::fromMap($map['userProb']);
        }

        return $model;
    }
}
