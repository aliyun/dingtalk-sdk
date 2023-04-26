<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveWhiteAppRequest extends Model
{
    /**
     * @var int[]
     */
    public $agentIdList;

    /**
     * @example add
     *
     * @var string
     */
    public $operation;
    protected $_name = [
        'agentIdList' => 'agentIdList',
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
        if (isset($map['operation'])) {
            $model->operation = $map['operation'];
        }

        return $model;
    }
}
