<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCooperateOrgRequest extends Model
{
    /**
     * @description 合作空间组织名称
     *
     * @var string
     */
    public $orgName;

    /**
     * @description 合作空间的logo
     *
     * @var string
     */
    public $logoMediaId;

    /**
     * @description 行业code
     *
     * @var int
     */
    public $industryCode;
    protected $_name = [
        'orgName'      => 'orgName',
        'logoMediaId'  => 'logoMediaId',
        'industryCode' => 'industryCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->logoMediaId) {
            $res['logoMediaId'] = $this->logoMediaId;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCooperateOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['logoMediaId'])) {
            $model->logoMediaId = $map['logoMediaId'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }

        return $model;
    }
}
