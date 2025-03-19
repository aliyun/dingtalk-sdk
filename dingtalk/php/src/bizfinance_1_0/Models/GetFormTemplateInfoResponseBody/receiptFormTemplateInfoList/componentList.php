<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetFormTemplateInfoResponseBody\receiptFormTemplateInfoList;

use AlibabaCloud\Tea\Model;

class componentList extends Model
{
    /**
     * @example \"100\"
     *
     * @var string
     */
    public $bindingVal;

    /**
     * @example \"xxx\"
     *
     * @var string
     */
    public $code;

    /**
     * @example "报销金额"
     *
     * @var string
     */
    public $name;

    /**
     * @example \"amount\"
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'bindingVal' => 'bindingVal',
        'code' => 'code',
        'name' => 'name',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingVal) {
            $res['bindingVal'] = $this->bindingVal;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return componentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingVal'])) {
            $model->bindingVal = $map['bindingVal'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
