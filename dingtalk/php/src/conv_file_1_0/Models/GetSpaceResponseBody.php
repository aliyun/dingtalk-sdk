<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\GetSpaceResponseBody\space;
use AlibabaCloud\Tea\Model;

class GetSpaceResponseBody extends Model
{
    /**
     * @description IM会话存储空间信息
     *
     * @var space
     */
    public $space;
    protected $_name = [
        'space' => 'space',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->space) {
            $res['space'] = null !== $this->space ? $this->space->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['space'])) {
            $model->space = space::fromMap($map['space']);
        }

        return $model;
    }
}
