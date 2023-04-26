<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RegisterOpenInfoRequest\openInfos;
use AlibabaCloud\Tea\Model;

class RegisterOpenInfoRequest extends Model
{
    /**
     * @var openInfos[]
     */
    public $openInfos;

    /**
     * @example DINGTALK
     *
     * @var string
     */
    public $provider;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'openInfos' => 'openInfos',
        'provider'  => 'provider',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openInfos) {
            $res['openInfos'] = [];
            if (null !== $this->openInfos && \is_array($this->openInfos)) {
                $n = 0;
                foreach ($this->openInfos as $item) {
                    $res['openInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->provider) {
            $res['provider'] = $this->provider;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterOpenInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openInfos'])) {
            if (!empty($map['openInfos'])) {
                $model->openInfos = [];
                $n                = 0;
                foreach ($map['openInfos'] as $item) {
                    $model->openInfos[$n++] = null !== $item ? openInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['provider'])) {
            $model->provider = $map['provider'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
