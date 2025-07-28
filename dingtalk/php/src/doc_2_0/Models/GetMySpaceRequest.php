<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetMySpaceRequest extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $isMySpace;
    protected $_name = [
        'isMySpace' => 'isMySpace',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isMySpace) {
            $res['isMySpace'] = $this->isMySpace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMySpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isMySpace'])) {
            $model->isMySpace = $map['isMySpace'];
        }

        return $model;
    }
}
