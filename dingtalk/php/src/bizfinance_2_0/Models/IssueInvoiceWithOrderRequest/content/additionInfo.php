<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest\content;

use AlibabaCloud\Tea\Model;

class additionInfo extends Model
{
    /**
     * @var string
     */
    public $additionContent;

    /**
     * @var string
     */
    public $additionName;

    /**
     * @var int
     */
    public $dataType;
    protected $_name = [
        'additionContent' => 'additionContent',
        'additionName' => 'additionName',
        'dataType' => 'dataType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->additionContent) {
            $res['additionContent'] = $this->additionContent;
        }
        if (null !== $this->additionName) {
            $res['additionName'] = $this->additionName;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return additionInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['additionContent'])) {
            $model->additionContent = $map['additionContent'];
        }
        if (isset($map['additionName'])) {
            $model->additionName = $map['additionName'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }

        return $model;
    }
}
