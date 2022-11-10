<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosResponseBody\multipartHeaderSignatureInfos;
use AlibabaCloud\Tea\Model;

class GetMultipartFileUploadInfosResponseBody extends Model
{
    /**
     * @description 分片Header加签上传信息列表
     * 30
     * @var multipartHeaderSignatureInfos[]
     */
    public $multipartHeaderSignatureInfos;
    protected $_name = [
        'multipartHeaderSignatureInfos' => 'multipartHeaderSignatureInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->multipartHeaderSignatureInfos) {
            $res['multipartHeaderSignatureInfos'] = [];
            if (null !== $this->multipartHeaderSignatureInfos && \is_array($this->multipartHeaderSignatureInfos)) {
                $n = 0;
                foreach ($this->multipartHeaderSignatureInfos as $item) {
                    $res['multipartHeaderSignatureInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMultipartFileUploadInfosResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['multipartHeaderSignatureInfos'])) {
            if (!empty($map['multipartHeaderSignatureInfos'])) {
                $model->multipartHeaderSignatureInfos = [];
                $n                                    = 0;
                foreach ($map['multipartHeaderSignatureInfos'] as $item) {
                    $model->multipartHeaderSignatureInfos[$n++] = null !== $item ? multipartHeaderSignatureInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
