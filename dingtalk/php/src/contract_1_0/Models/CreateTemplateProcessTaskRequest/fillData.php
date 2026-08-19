<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateTemplateProcessTaskRequest;

use AlibabaCloud\Tea\Model;

class fillData extends Model
{
    /**
     * @var string
     */
    public $structKey;

    /**
     * @var string
     */
    public $structValue;
    protected $_name = [
        'structKey' => 'structKey',
        'structValue' => 'structValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->structKey) {
            $res['structKey'] = $this->structKey;
        }
        if (null !== $this->structValue) {
            $res['structValue'] = $this->structValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fillData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['structKey'])) {
            $model->structKey = $map['structKey'];
        }
        if (isset($map['structValue'])) {
            $model->structValue = $map['structValue'];
        }

        return $model;
    }
}
