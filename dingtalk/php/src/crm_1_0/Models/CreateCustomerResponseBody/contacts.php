<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerResponseBody;

use AlibabaCloud\Tea\Model;

class contacts extends Model
{
    /**
     * @description 联系人实例id
     *
     * @var string
     */
    public $contactInstanceId;
    protected $_name = [
        'contactInstanceId' => 'contactInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactInstanceId) {
            $res['contactInstanceId'] = $this->contactInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contacts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactInstanceId'])) {
            $model->contactInstanceId = $map['contactInstanceId'];
        }

        return $model;
    }
}
