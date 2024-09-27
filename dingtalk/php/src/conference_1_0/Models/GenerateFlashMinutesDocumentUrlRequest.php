<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GenerateFlashMinutesDocumentUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cloud_record
     *
     * @var string
     */
    public $bizType;

    /**
     * @example 1727185971000
     *
     * @var int
     */
    public $expireTime;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRG9KXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizType'    => 'bizType',
        'expireTime' => 'expireTime',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateFlashMinutesDocumentUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
