<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExportPointOpenRequest extends Model
{
    /**
     * @example 20220601
     *
     * @var string
     */
    public $exportDate;

    /**
     * @example 1
     *
     * @var int
     */
    public $exportType;

    /**
     * @example 11185568-1380470824
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'exportDate' => 'exportDate',
        'exportType' => 'exportType',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->exportDate) {
            $res['exportDate'] = $this->exportDate;
        }
        if (null !== $this->exportType) {
            $res['exportType'] = $this->exportType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExportPointOpenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['exportDate'])) {
            $model->exportDate = $map['exportDate'];
        }
        if (isset($map['exportType'])) {
            $model->exportType = $map['exportType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
