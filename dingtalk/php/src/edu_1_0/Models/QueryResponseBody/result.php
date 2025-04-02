<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $ownerCode;
    protected $_name = [
        'name' => 'name',
        'ownerCode' => 'ownerCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerCode) {
            $res['ownerCode'] = $this->ownerCode;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerCode'])) {
            $model->ownerCode = $map['ownerCode'];
        }

        return $model;
    }
}
