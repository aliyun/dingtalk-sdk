<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallOTORequest extends Model
{
    /**
     * @description 机器人的robotCode
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 消息id
     *
     * @var string[]
     */
    public $processQueryKeys;
    protected $_name = [
        'robotCode'        => 'robotCode',
        'processQueryKeys' => 'processQueryKeys',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->processQueryKeys) {
            $res['processQueryKeys'] = $this->processQueryKeys;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRecallOTORequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['processQueryKeys'])) {
            if (!empty($map['processQueryKeys'])) {
                $model->processQueryKeys = $map['processQueryKeys'];
            }
        }

        return $model;
    }
}
