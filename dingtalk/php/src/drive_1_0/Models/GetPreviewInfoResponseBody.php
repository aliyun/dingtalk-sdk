<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPreviewInfoResponseBody\info;
use AlibabaCloud\Tea\Model;

class GetPreviewInfoResponseBody extends Model
{
    /**
     * @description 预览信息
     *
     * @var info
     */
    public $info;
    protected $_name = [
        'info' => 'info',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->info) {
            $res['info'] = null !== $this->info ? $this->info->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPreviewInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['info'])) {
            $model->info = info::fromMap($map['info']);
        }

        return $model;
    }
}
