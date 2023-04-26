<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO;

use AlibabaCloud\Tea\Model;

class visitInfo extends Model
{
    /**
     * @example 5
     *
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'roleCode' => 'roleCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visitInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
