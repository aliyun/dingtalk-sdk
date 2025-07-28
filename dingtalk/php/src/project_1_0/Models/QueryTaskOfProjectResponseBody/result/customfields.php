<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponseBody\result;

use AlibabaCloud\Tea\Model;

class customfields extends Model
{
    /**
     * @example 62c25e3bbxx0xxx
     *
     * @var string
     */
    public $customfieldId;
    protected $_name = [
        'customfieldId' => 'customfieldId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldId) {
            $res['customfieldId'] = $this->customfieldId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customfields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }

        return $model;
    }
}
