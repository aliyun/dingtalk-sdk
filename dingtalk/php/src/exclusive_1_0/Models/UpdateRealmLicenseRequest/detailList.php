<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\UpdateRealmLicenseRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @example 1001
     *
     * @var int
     */
    public $licenseType;

    /**
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'licenseType' => 'licenseType',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->licenseType) {
            $res['licenseType'] = $this->licenseType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['licenseType'])) {
            $model->licenseType = $map['licenseType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
