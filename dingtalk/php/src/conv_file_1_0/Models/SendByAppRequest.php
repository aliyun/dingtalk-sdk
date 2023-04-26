<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendByAppRequest extends Model
{
    /**
     * @example file_id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @example space_id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryId' => 'dentryId',
        'spaceId'  => 'spaceId',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendByAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
