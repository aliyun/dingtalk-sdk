<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 优先使用内网传输
     * true
     * @var bool
     */
    public $preferIntranet;
    protected $_name = [
        'preferIntranet' => 'preferIntranet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->preferIntranet) {
            $res['preferIntranet'] = $this->preferIntranet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['preferIntranet'])) {
            $model->preferIntranet = $map['preferIntranet'];
        }

        return $model;
    }
}
