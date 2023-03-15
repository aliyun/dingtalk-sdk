<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest;

use AlibabaCloud\Tea\Model;

class templateConfig extends Model
{
    /**
     * @description 表单创建移动端地址
     *
     * @var string
     */
    public $createInstanceMobileUrl;

    /**
     * @description 表单创建PC端地址
     *
     * @var string
     */
    public $createInstancePcUrl;

    /**
     * @var bool
     */
    public $disableSendCard;

    /**
     * @description 是否为隐藏模板
     *
     * @var bool
     */
    public $hidden;

    /**
     * @description 模板编辑地址
     *
     * @var string
     */
    public $templateEditUrl;
    protected $_name = [
        'createInstanceMobileUrl' => 'createInstanceMobileUrl',
        'createInstancePcUrl'     => 'createInstancePcUrl',
        'disableSendCard'         => 'disableSendCard',
        'hidden'                  => 'hidden',
        'templateEditUrl'         => 'templateEditUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createInstanceMobileUrl) {
            $res['createInstanceMobileUrl'] = $this->createInstanceMobileUrl;
        }
        if (null !== $this->createInstancePcUrl) {
            $res['createInstancePcUrl'] = $this->createInstancePcUrl;
        }
        if (null !== $this->disableSendCard) {
            $res['disableSendCard'] = $this->disableSendCard;
        }
        if (null !== $this->hidden) {
            $res['hidden'] = $this->hidden;
        }
        if (null !== $this->templateEditUrl) {
            $res['templateEditUrl'] = $this->templateEditUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createInstanceMobileUrl'])) {
            $model->createInstanceMobileUrl = $map['createInstanceMobileUrl'];
        }
        if (isset($map['createInstancePcUrl'])) {
            $model->createInstancePcUrl = $map['createInstancePcUrl'];
        }
        if (isset($map['disableSendCard'])) {
            $model->disableSendCard = $map['disableSendCard'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['templateEditUrl'])) {
            $model->templateEditUrl = $map['templateEditUrl'];
        }

        return $model;
    }
}
