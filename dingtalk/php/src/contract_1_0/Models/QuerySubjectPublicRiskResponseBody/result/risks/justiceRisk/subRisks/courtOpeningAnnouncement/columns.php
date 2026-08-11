<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\justiceRisk\subRisks\courtOpeningAnnouncement;

use AlibabaCloud\Tea\Model;

class columns extends Model
{
    /**
     * @var string
     */
    public $columnName;

    /**
     * @var string
     */
    public $columnType;

    /**
     * @var bool
     */
    public $isDate;
    protected $_name = [
        'columnName' => 'columnName',
        'columnType' => 'columnType',
        'isDate' => 'isDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnName) {
            $res['columnName'] = $this->columnName;
        }
        if (null !== $this->columnType) {
            $res['columnType'] = $this->columnType;
        }
        if (null !== $this->isDate) {
            $res['isDate'] = $this->isDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return columns
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnName'])) {
            $model->columnName = $map['columnName'];
        }
        if (isset($map['columnType'])) {
            $model->columnType = $map['columnType'];
        }
        if (isset($map['isDate'])) {
            $model->isDate = $map['isDate'];
        }

        return $model;
    }
}
