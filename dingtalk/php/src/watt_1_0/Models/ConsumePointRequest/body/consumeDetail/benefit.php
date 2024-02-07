<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest\body\consumeDetail;

use AlibabaCloud\Tea\Model;

class benefit extends Model
{
    /**
     * @var string
     */
    public $benefitId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $supplierName;

    /**
     * @var string
     */
    public $useUrl;
    protected $_name = [
        'benefitId'    => 'benefitId',
        'name'         => 'name',
        'supplierName' => 'supplierName',
        'useUrl'       => 'useUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitId) {
            $res['benefitId'] = $this->benefitId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->supplierName) {
            $res['supplierName'] = $this->supplierName;
        }
        if (null !== $this->useUrl) {
            $res['useUrl'] = $this->useUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return benefit
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitId'])) {
            $model->benefitId = $map['benefitId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['supplierName'])) {
            $model->supplierName = $map['supplierName'];
        }
        if (isset($map['useUrl'])) {
            $model->useUrl = $map['useUrl'];
        }

        return $model;
    }
}
