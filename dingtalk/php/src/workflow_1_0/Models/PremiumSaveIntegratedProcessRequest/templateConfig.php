<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessRequest;

use AlibabaCloud\Tea\Model;

class templateConfig extends Model
{
    /**
     * @example https://open.dingtalk.com/
     *
     * @deprecated
     *
     * @var string
     */
    public $createInstanceMobileUrl;

    /**
     * @example https://open.dingtalk.com/
     *
     * @deprecated
     *
     * @var string
     */
    public $createInstancePcUrl;

    /**
     * @var bool
     */
    public $disableSendCard;

    /**
     * @example true
     *
     * @var bool
     */
    public $hidden;

    /**
     * @example https://open.dingtalk.com/
     *
     * @deprecated
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
