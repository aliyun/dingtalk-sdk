<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RegisterOpenInfoRequest;

use AlibabaCloud\Tea\Model;

class openInfos extends Model
{
    /**
     * @description 打开方式
     * EDIT: 编辑
     * @var string
     */
    public $openType;

    /**
     * @description 注册链接
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'openType' => 'openType',
        'url'      => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openType) {
            $res['openType'] = $this->openType;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openType'])) {
            $model->openType = $map['openType'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
