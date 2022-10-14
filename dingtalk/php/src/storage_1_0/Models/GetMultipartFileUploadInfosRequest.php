<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMultipartFileUploadInfosRequest extends Model
{
    /**
     * @description 分片id列表
     * 分片大小限制: 100KB~5GB
     * @var int[]
     */
    public $partNumbers;

    /**
     * @description 上传唯一标识
     *
     * @var string
     */
    public $uploadKey;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
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
