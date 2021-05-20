<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataRequest;

use AlibabaCloud\Tea\Model;

class triggerDataList extends Model
{
    /**
     * @var string
     */
    public $triggerId;

    /**
     * @var string
     */
    public $customTriggerId;

    /**
     * @var string
     */
    public $jsonData;

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
    public $action;
    protected $_name = [
        'triggerId'       => 'triggerId',
        'customTriggerId' => 'customTriggerId',
        'jsonData'        => 'jsonData',
        'dataGmtCreate'   => 'dataGmtCreate',
        'dataGmtModified' => 'dataGmtModified',
        'action'          => 'action',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->triggerId) {
            $res['triggerId'] = $this->triggerId;
        }
        if (null !== $this->customTriggerId) {
            $res['customTriggerId'] = $this->customTriggerId;
        }
        if (null !== $this->jsonData) {
            $res['jsonData'] = $this->jsonData;
        }
        if (null !== $this->dataGmtCreate) {
            $res['dataGmtCreate'] = $this->dataGmtCreate;
        }
        if (null !== $this->dataGmtModified) {
            $res['dataGmtModified'] = $this->dataGmtModified;
        }
        if (null !== $this->action) {
            $res['action'] = $this->action;
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
        if (isset($map['triggerId'])) {
            $model->triggerId = $map['triggerId'];
        }
        if (isset($map['customTriggerId'])) {
            $model->customTriggerId = $map['customTriggerId'];
        }
        if (isset($map['jsonData'])) {
            $model->jsonData = $map['jsonData'];
        }
        if (isset($map['dataGmtCreate'])) {
            $model->dataGmtCreate = $map['dataGmtCreate'];
        }
        if (isset($map['dataGmtModified'])) {
            $model->dataGmtModified = $map['dataGmtModified'];
        }
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }

        return $model;
    }
}
