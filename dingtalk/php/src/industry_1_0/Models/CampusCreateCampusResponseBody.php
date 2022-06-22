<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusCreateCampusResponseBody extends Model
{
    /**
     * @description 园区组织ID
     *
     * @var string
     */
    public $campusCorpId;

    /**
     * @description 园区部门ID
     *
     * @var string
     */
    public $campusDeptId;
    protected $_name = [
        'campusCorpId' => 'campusCorpId',
        'campusDeptId' => 'campusDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->campusCorpId) {
            $res['campusCorpId'] = $this->campusCorpId;
        }
        if (null !== $this->campusDeptId) {
            $res['campusDeptId'] = $this->campusDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusCreateCampusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['campusCorpId'])) {
            $model->campusCorpId = $map['campusCorpId'];
        }
        if (isset($map['campusDeptId'])) {
            $model->campusDeptId = $map['campusDeptId'];
        }

        return $model;
    }
}
