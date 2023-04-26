<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateRequest\taskScopeVO;
use AlibabaCloud\Tea\Model;

class SyncTaskTemplateRequest extends Model
{
    /**
     * @var bool
     */
    public $delete;

    /**
     * @example 培训、薪酬任务模版
     *
     * @var string
     */
    public $des;

    /**
     * @example {\"key\":value}
     *
     * @var string
     */
    public $ext;

    /**
     * @example 培训模版
     *
     * @var string
     */
    public $name;

    /**
     * @example 23234
     *
     * @var string
     */
    public $optUserId;

    /**
     * @example 232332
     *
     * @var string
     */
    public $outerId;

    /**
     * @var taskScopeVO
     */
    public $taskScopeVO;

    /**
     * @example PERFORMANCE_TASK、TRAIN_TASK
     *
     * @var string
     */
    public $taskType;

    /**
     * @example onboarding
     *
     * @var string
     */
    public $solutionType;
    protected $_name = [
        'delete'       => 'delete',
        'des'          => 'des',
        'ext'          => 'ext',
        'name'         => 'name',
        'optUserId'    => 'optUserId',
        'outerId'      => 'outerId',
        'taskScopeVO'  => 'taskScopeVO',
        'taskType'     => 'taskType',
        'solutionType' => 'solutionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delete) {
            $res['delete'] = $this->delete;
        }
        if (null !== $this->des) {
            $res['des'] = $this->des;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }
        if (null !== $this->taskScopeVO) {
            $res['taskScopeVO'] = null !== $this->taskScopeVO ? $this->taskScopeVO->toMap() : null;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->solutionType) {
            $res['solutionType'] = $this->solutionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncTaskTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['delete'])) {
            $model->delete = $map['delete'];
        }
        if (isset($map['des'])) {
            $model->des = $map['des'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }
        if (isset($map['taskScopeVO'])) {
            $model->taskScopeVO = taskScopeVO::fromMap($map['taskScopeVO']);
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['solutionType'])) {
            $model->solutionType = $map['solutionType'];
        }

        return $model;
    }
}
