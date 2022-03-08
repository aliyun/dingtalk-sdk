<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponseBody\result\actionExecutor;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponseBody\result\originator;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 流程实例当前任务执行人列表
     *
     * @var actionExecutor[]
     */
    public $actionExecutor;

    /**
     * @description 流程结束时的审批结论
     *
     * @var string
     */
    public $approvedResult;

    /**
     * @description 表单数据
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description 流程表单ID
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 实例状态
     *
     * @var string
     */
    public $instanceStatus;

    /**
     * @description 发起人信息
     *
     * @var originator
     */
    public $originator;

    /**
     * @description 流程Code
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 实例标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionExecutor'    => 'actionExecutor',
        'approvedResult'    => 'approvedResult',
        'data'              => 'data',
        'formUuid'          => 'formUuid',
        'instanceStatus'    => 'instanceStatus',
        'originator'        => 'originator',
        'processCode'       => 'processCode',
        'processInstanceId' => 'processInstanceId',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionExecutor) {
            $res['actionExecutor'] = [];
            if (null !== $this->actionExecutor && \is_array($this->actionExecutor)) {
                $n = 0;
                foreach ($this->actionExecutor as $item) {
                    $res['actionExecutor'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->approvedResult) {
            $res['approvedResult'] = $this->approvedResult;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->instanceStatus) {
            $res['instanceStatus'] = $this->instanceStatus;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionExecutor'])) {
            if (!empty($map['actionExecutor'])) {
                $model->actionExecutor = [];
                $n                     = 0;
                foreach ($map['actionExecutor'] as $item) {
                    $model->actionExecutor[$n++] = null !== $item ? actionExecutor::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['approvedResult'])) {
            $model->approvedResult = $map['approvedResult'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['instanceStatus'])) {
            $model->instanceStatus = $map['instanceStatus'];
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
