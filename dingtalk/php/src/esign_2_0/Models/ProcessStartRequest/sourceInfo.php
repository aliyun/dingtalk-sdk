<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest;

use AlibabaCloud\Tea\Model;

class sourceInfo extends Model
{
    /**
     * @description 展示文案
     *
     * @var string
     */
    public $showText;

    /**
     * @description pc端跳转地址
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description 移动端跳转地址
     *
     * @var string
     */
    public $mobileUrl;
    protected $_name = [
        'showText'  => 'showText',
        'pcUrl'     => 'pcUrl',
        'mobileUrl' => 'mobileUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->showText) {
            $res['showText'] = $this->showText;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sourceInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['showText'])) {
            $model->showText = $map['showText'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }

        return $model;
    }
}
