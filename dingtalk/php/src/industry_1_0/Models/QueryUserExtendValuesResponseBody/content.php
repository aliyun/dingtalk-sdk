<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userCode;

    /**
     * @var string
     */
    public $userExtendDisplayName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userExtendKey;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userExtendValue;
    protected $_name = [
        'userCode' => 'userCode',
        'userExtendDisplayName' => 'userExtendDisplayName',
        'userExtendKey' => 'userExtendKey',
        'userExtendValue' => 'userExtendValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->userCode) {
            $res['userCode'] = $this->userCode;
        }
        if (null !== $this->userExtendDisplayName) {
            $res['userExtendDisplayName'] = $this->userExtendDisplayName;
        }
        if (null !== $this->userExtendKey) {
            $res['userExtendKey'] = $this->userExtendKey;
        }
        if (null !== $this->userExtendValue) {
            $res['userExtendValue'] = $this->userExtendValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userCode'])) {
            $model->userCode = $map['userCode'];
        }
        if (isset($map['userExtendDisplayName'])) {
            $model->userExtendDisplayName = $map['userExtendDisplayName'];
        }
        if (isset($map['userExtendKey'])) {
            $model->userExtendKey = $map['userExtendKey'];
        }
        if (isset($map['userExtendValue'])) {
            $model->userExtendValue = $map['userExtendValue'];
        }

        return $model;
    }
}
