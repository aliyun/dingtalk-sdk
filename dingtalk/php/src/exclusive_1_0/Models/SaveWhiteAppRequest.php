<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveWhiteAppRequest extends Model
{
    /**
     * @deprecated
     *
     * @var int[]
     */
    public $agentIdList;

    /**
     * @description This parameter is required.
     *
     * @example {"openShareControl":[123],"openClipboardPaste":[123]}
     *
     * @var string
     */
    public $agentIdMap;

    /**
     * @example add
     *
     * @deprecated
     *
     * @var string
     */
    public $operation;
    protected $_name = [
        'agentIdList' => 'agentIdList',
        'agentIdMap'  => 'agentIdMap',
        'operation'   => 'operation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentIdList) {
            $res['agentIdList'] = $this->agentIdList;
        }
        if (null !== $this->agentIdMap) {
            $res['agentIdMap'] = $this->agentIdMap;
        }
        if (null !== $this->operation) {
            $res['operation'] = $this->operation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveWhiteAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentIdList'])) {
            if (!empty($map['agentIdList'])) {
                $model->agentIdList = $map['agentIdList'];
            }
        }
        if (isset($map['agentIdMap'])) {
            $model->agentIdMap = $map['agentIdMap'];
        }
        if (isset($map['operation'])) {
            $model->operation = $map['operation'];
        }

        return $model;
    }
}
