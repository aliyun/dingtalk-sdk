<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody\android;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody\iOS;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody\mac;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody\windows;
use AlibabaCloud\Tea\Model;

class GetAppDispatchInfoResponseBody extends Model
{
    /**
     * @description android打包记录
     *
     * @var android[]
     */
    public $android;

    /**
     * @description iOS打包记录
     *
     * @var iOS[]
     */
    public $iOS;

    /**
     * @description mac打包记录
     *
     * @var mac[]
     */
    public $mac;

    /**
     * @description windows打包记录
     *
     * @var windows[]
     */
    public $windows;
    protected $_name = [
        'android' => 'android',
        'iOS'     => 'iOS',
        'mac'     => 'mac',
        'windows' => 'windows',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->android) {
            $res['android'] = [];
            if (null !== $this->android && \is_array($this->android)) {
                $n = 0;
                foreach ($this->android as $item) {
                    $res['android'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->iOS) {
            $res['iOS'] = [];
            if (null !== $this->iOS && \is_array($this->iOS)) {
                $n = 0;
                foreach ($this->iOS as $item) {
                    $res['iOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mac) {
            $res['mac'] = [];
            if (null !== $this->mac && \is_array($this->mac)) {
                $n = 0;
                foreach ($this->mac as $item) {
                    $res['mac'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->windows) {
            $res['windows'] = [];
            if (null !== $this->windows && \is_array($this->windows)) {
                $n = 0;
                foreach ($this->windows as $item) {
                    $res['windows'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppDispatchInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['android'])) {
            if (!empty($map['android'])) {
                $model->android = [];
                $n              = 0;
                foreach ($map['android'] as $item) {
                    $model->android[$n++] = null !== $item ? android::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['iOS'])) {
            if (!empty($map['iOS'])) {
                $model->iOS = [];
                $n          = 0;
                foreach ($map['iOS'] as $item) {
                    $model->iOS[$n++] = null !== $item ? iOS::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mac'])) {
            if (!empty($map['mac'])) {
                $model->mac = [];
                $n          = 0;
                foreach ($map['mac'] as $item) {
                    $model->mac[$n++] = null !== $item ? mac::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['windows'])) {
            if (!empty($map['windows'])) {
                $model->windows = [];
                $n              = 0;
                foreach ($map['windows'] as $item) {
                    $model->windows[$n++] = null !== $item ? windows::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
