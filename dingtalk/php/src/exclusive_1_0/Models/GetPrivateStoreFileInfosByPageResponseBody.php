<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileInfosByPageResponseBody\fileInfos;
use AlibabaCloud\Tea\Model;

class GetPrivateStoreFileInfosByPageResponseBody extends Model
{
    /**
     * @var fileInfos[]
     */
    public $fileInfos;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'fileInfos' => 'fileInfos',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileInfos) {
            $res['fileInfos'] = [];
            if (null !== $this->fileInfos && \is_array($this->fileInfos)) {
                $n = 0;
                foreach ($this->fileInfos as $item) {
                    $res['fileInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreFileInfosByPageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileInfos'])) {
            if (!empty($map['fileInfos'])) {
                $model->fileInfos = [];
                $n = 0;
                foreach ($map['fileInfos'] as $item) {
                    $model->fileInfos[$n++] = null !== $item ? fileInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
