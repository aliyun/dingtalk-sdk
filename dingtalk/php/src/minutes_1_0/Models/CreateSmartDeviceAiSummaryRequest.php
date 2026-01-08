<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSmartDeviceAiSummaryRequest extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $isvContext;

    /**
     * @var string
     */
    public $openFileId;
    protected $_name = [
        'agentId' => 'agentId',
        'instanceId' => 'instanceId',
        'isvContext' => 'isvContext',
        'openFileId' => 'openFileId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->isvContext) {
            $res['isvContext'] = $this->isvContext;
        }
        if (null !== $this->openFileId) {
            $res['openFileId'] = $this->openFileId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSmartDeviceAiSummaryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['isvContext'])) {
            $model->isvContext = $map['isvContext'];
        }
        if (isset($map['openFileId'])) {
            $model->openFileId = $map['openFileId'];
        }

        return $model;
    }
}
