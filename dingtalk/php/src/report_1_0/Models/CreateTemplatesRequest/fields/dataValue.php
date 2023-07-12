<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest\fields;

use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest\fields\dataValue\openInfo;
use AlibabaCloud\Tea\Model;

class dataValue extends Model
{
    /**
     * @var openInfo
     */
    public $openInfo;

    /**
     * @var string[]
     */
    public $options;

    /**
     * @var string
     */
    public $placeholder;
    protected $_name = [
        'openInfo'    => 'openInfo',
        'options'     => 'options',
        'placeholder' => 'placeholder',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openInfo) {
            $res['openInfo'] = null !== $this->openInfo ? $this->openInfo->toMap() : null;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openInfo'])) {
            $model->openInfo = openInfo::fromMap($map['openInfo']);
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = $map['options'];
            }
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }

        return $model;
    }
}
