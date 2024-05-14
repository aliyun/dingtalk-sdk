<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosRequest\option;
use AlibabaCloud\Tea\Model;

class GetMultipartFileUploadInfosRequest extends Model
{
    /**
     * @var option
     */
    public $option;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $partNumbers;

    /**
     * @description This parameter is required.
     *
     * @example upload_key
     *
     * @var string
     */
    public $uploadKey;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'option'      => 'option',
        'partNumbers' => 'partNumbers',
        'uploadKey'   => 'uploadKey',
        'unionId'     => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->partNumbers) {
            $res['partNumbers'] = $this->partNumbers;
        }
        if (null !== $this->uploadKey) {
            $res['uploadKey'] = $this->uploadKey;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMultipartFileUploadInfosRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['partNumbers'])) {
            if (!empty($map['partNumbers'])) {
                $model->partNumbers = $map['partNumbers'];
            }
        }
        if (isset($map['uploadKey'])) {
            $model->uploadKey = $map['uploadKey'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
