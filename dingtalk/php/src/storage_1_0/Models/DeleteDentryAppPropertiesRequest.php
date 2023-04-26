<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteDentryAppPropertiesRequest extends Model
{
    /**
     * @var string[]
     */
    public $propertyNames;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'propertyNames' => 'propertyNames',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->propertyNames) {
            $res['propertyNames'] = $this->propertyNames;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDentryAppPropertiesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['propertyNames'])) {
            if (!empty($map['propertyNames'])) {
                $model->propertyNames = $map['propertyNames'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
