<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCooperateOrgRequest extends Model
{
    /**
     * @description 行业code
     *
     * @var int
     */
    public $industryCode;

    /**
     * @description 合作空间的logo
     *
     * @var string
     */
    public $logoMediaId;

    /**
     * @description 合作空间组织名称
     *
     * @var string
     */
    public $orgName;
    protected $_name = [
        'industryCode' => 'industryCode',
        'logoMediaId'  => 'logoMediaId',
        'orgName'      => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->logoMediaId) {
            $res['logoMediaId'] = $this->logoMediaId;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
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
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['logoMediaId'])) {
            $model->logoMediaId = $map['logoMediaId'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
