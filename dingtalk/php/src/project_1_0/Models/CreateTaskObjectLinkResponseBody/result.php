<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $created;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $objectLinkId;
    protected $_name = [
        'created' => 'created',
        'objectLinkId' => 'objectLinkId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->objectLinkId) {
            $res['objectLinkId'] = $this->objectLinkId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['objectLinkId'])) {
            $model->objectLinkId = $map['objectLinkId'];
        }

        return $model;
    }
}
