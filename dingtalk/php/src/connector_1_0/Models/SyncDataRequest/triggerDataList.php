<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataRequest;

use AlibabaCloud\Tea\Model;

class triggerDataList extends Model
{
    /**
     * @var string
     */
    public $action;

    /**
     * @var string
     */
    public $customTriggerId;

    /**
     * @var int
     */
    public $dataGmtCreate;

    /**
     * @var int
     */
    public $dataGmtModified;

    /**
     * @var string
     */
    public $integrationObject;

    /**
     * @var string
     */
    public $jsonData;

    /**
     * @var string
     */
    public $triggerCondition;

    /**
     * @var string
     */
    public $triggerId;
    protected $_name = [
        'action'            => 'action',
        'customTriggerId'   => 'customTriggerId',
        'dataGmtCreate'     => 'dataGmtCreate',
        'dataGmtModified'   => 'dataGmtModified',
        'integrationObject' => 'integrationObject',
        'jsonData'          => 'jsonData',
        'triggerCondition'  => 'triggerCondition',
        'triggerId'         => 'triggerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->customTriggerId) {
            $res['customTriggerId'] = $this->customTriggerId;
        }
        if (null !== $this->dataGmtCreate) {
            $res['dataGmtCreate'] = $this->dataGmtCreate;
        }
        if (null !== $this->dataGmtModified) {
            $res['dataGmtModified'] = $this->dataGmtModified;
        }
        if (null !== $this->integrationObject) {
            $res['integrationObject'] = $this->integrationObject;
        }
        if (null !== $this->jsonData) {
            $res['jsonData'] = $this->jsonData;
        }
        if (null !== $this->triggerCondition) {
            $res['triggerCondition'] = $this->triggerCondition;
        }
        if (null !== $this->triggerId) {
            $res['triggerId'] = $this->triggerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return triggerDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['customTriggerId'])) {
            $model->customTriggerId = $map['customTriggerId'];
        }
        if (isset($map['dataGmtCreate'])) {
            $model->dataGmtCreate = $map['dataGmtCreate'];
        }
        if (isset($map['dataGmtModified'])) {
            $model->dataGmtModified = $map['dataGmtModified'];
        }
        if (isset($map['integrationObject'])) {
            $model->integrationObject = $map['integrationObject'];
        }
        if (isset($map['jsonData'])) {
            $model->jsonData = $map['jsonData'];
        }
        if (isset($map['triggerCondition'])) {
            $model->triggerCondition = $map['triggerCondition'];
        }
        if (isset($map['triggerId'])) {
            $model->triggerId = $map['triggerId'];
        }

        return $model;
    }
}
