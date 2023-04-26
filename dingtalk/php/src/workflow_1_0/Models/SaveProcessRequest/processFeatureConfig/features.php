<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest\processFeatureConfig;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest\processFeatureConfig\features\callback;
use AlibabaCloud\Tea\Model;

class features extends Model
{
    /**
     * @var callback
     */
    public $callback;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example abc
     *
     * @var string
     */
    public $name;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @example ORIGIN
     *
     * @var string
     */
    public $runType;
    protected $_name = [
        'callback'  => 'callback',
        'mobileUrl' => 'mobileUrl',
        'name'      => 'name',
        'pcUrl'     => 'pcUrl',
        'runType'   => 'runType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callback) {
            $res['callback'] = null !== $this->callback ? $this->callback->toMap() : null;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->runType) {
            $res['runType'] = $this->runType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return features
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callback'])) {
            $model->callback = callback::fromMap($map['callback']);
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['runType'])) {
            $model->runType = $map['runType'];
        }

        return $model;
    }
}
