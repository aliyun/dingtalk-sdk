<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppResponseBody\app;
use AlibabaCloud\Tea\Model;

class GetCurrentAppResponseBody extends Model
{
    /**
     * @description 企业存储应用信息
     *
     * @var app
     */
    public $app;
    protected $_name = [
        'app' => 'app',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->app) {
            $res['app'] = null !== $this->app ? $this->app->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCurrentAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app'])) {
            $model->app = app::fromMap($map['app']);
        }

        return $model;
    }
}
