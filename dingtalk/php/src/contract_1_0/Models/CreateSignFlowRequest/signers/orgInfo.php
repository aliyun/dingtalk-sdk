<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers;

use AlibabaCloud\Tea\Model;

class orgInfo extends Model
{
    /**
     * @var string
     */
    public $companyId;

    /**
     * @var string
     */
    public $orgName;
    protected $_name = [
        'companyId' => 'companyId',
        'orgName' => 'orgName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyId) {
            $res['companyId'] = $this->companyId;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyId'])) {
            $model->companyId = $map['companyId'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
