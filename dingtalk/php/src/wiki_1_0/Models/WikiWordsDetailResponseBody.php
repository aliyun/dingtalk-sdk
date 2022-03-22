<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsDetailResponseBody\data;
use AlibabaCloud\Tea\Model;

class WikiWordsDetailResponseBody extends Model
{
    /**
     * @description 返回的参数
     *
     * @var data[]
     */
    public $data;

    /**
     * @description 返回的错误信息
     *
     * @var string
     */
    public $errMsg;

    /**
     * @description 查询是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'data'    => 'data',
        'errMsg'  => 'errMsg',
        'success' => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->errMsg) {
            $res['errMsg'] = $this->errMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WikiWordsDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['errMsg'])) {
            $model->errMsg = $map['errMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
