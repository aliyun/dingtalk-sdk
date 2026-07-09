<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\signComponentConfig\signFieldComponentConfig;

use AlibabaCloud\Tea\Model;

class signDateConfig extends Model
{
    /**
     * @var string
     */
    public $dateFormat;

    /**
     * @var bool
     */
    public $showSignDate;
    protected $_name = [
        'dateFormat' => 'dateFormat',
        'showSignDate' => 'showSignDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dateFormat) {
            $res['dateFormat'] = $this->dateFormat;
        }
        if (null !== $this->showSignDate) {
            $res['showSignDate'] = $this->showSignDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signDateConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dateFormat'])) {
            $model->dateFormat = $map['dateFormat'];
        }
        if (isset($map['showSignDate'])) {
            $model->showSignDate = $map['showSignDate'];
        }

        return $model;
    }
}
