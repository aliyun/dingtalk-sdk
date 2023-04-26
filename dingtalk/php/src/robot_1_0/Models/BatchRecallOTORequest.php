<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRecallOTORequest extends Model
{
    /**
     * @var string[]
     */
    public $processQueryKeys;

    /**
     * @example dingXXXXXX
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'processQueryKeys' => 'processQueryKeys',
        'robotCode'        => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processQueryKeys) {
            $res['processQueryKeys'] = $this->processQueryKeys;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
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
        if (isset($map['processQueryKeys'])) {
            if (!empty($map['processQueryKeys'])) {
                $model->processQueryKeys = $map['processQueryKeys'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
