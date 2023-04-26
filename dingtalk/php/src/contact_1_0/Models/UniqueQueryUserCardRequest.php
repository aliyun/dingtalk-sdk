<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UniqueQueryUserCardRequest extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $templateId;

    /**
     * @example dfsdfsfsfdsfs
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'templateId' => 'templateId',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UniqueQueryUserCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
