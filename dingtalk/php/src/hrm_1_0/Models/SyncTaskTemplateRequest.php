<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateRequest\taskScopeVO;
use AlibabaCloud\Tea\Model;

class SyncTaskTemplateRequest extends Model
{
    /**
     * @description 是否删除任务模版，true删除，false不删除
     *
     * @var bool
     */
    public $delete;

    /**
     * @description 任务模板描述
     *
     * @var string
     */
    public $des;

    /**
     * @description 扩展信息，json串
     *
     * @var string
     */
    public $ext;

    /**
     * @description 模版名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 任务模版创建人staffId
     *
     * @var string
     */
    public $optUserId;

    /**
     * @description isv对应的任务模版唯一键
     *
     * @var string
     */
    public $outerId;

    /**
     * @description 圈人规则
     *
     * @var taskScopeVO
     */
    public $taskScopeVO;

    /**
     * @description 任务模版类型：TRAIN_TASK、PERFORMANCE_TASK
     *
     * @var string
     */
    public $taskType;

    /**
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
