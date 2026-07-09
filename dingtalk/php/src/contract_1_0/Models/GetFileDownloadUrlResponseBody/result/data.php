<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetFileDownloadUrlResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetFileDownloadUrlResponseBody\result\data\attachment;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetFileDownloadUrlResponseBody\result\data\signDocs;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var attachment[]
     */
    public $attachment;

    /**
     * @var signDocs[]
     */
    public $signDocs;

    /**
     * @var string
     */
    public $signFlowId;
    protected $_name = [
        'attachment' => 'attachment',
        'signDocs' => 'signDocs',
        'signFlowId' => 'signFlowId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachment) {
            $res['attachment'] = [];
            if (null !== $this->attachment && \is_array($this->attachment)) {
                $n = 0;
                foreach ($this->attachment as $item) {
                    $res['attachment'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->signDocs) {
            $res['signDocs'] = [];
            if (null !== $this->signDocs && \is_array($this->signDocs)) {
                $n = 0;
                foreach ($this->signDocs as $item) {
                    $res['signDocs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachment'])) {
            if (!empty($map['attachment'])) {
                $model->attachment = [];
                $n = 0;
                foreach ($map['attachment'] as $item) {
                    $model->attachment[$n++] = null !== $item ? attachment::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['signDocs'])) {
            if (!empty($map['signDocs'])) {
                $model->signDocs = [];
                $n = 0;
                foreach ($map['signDocs'] as $item) {
                    $model->signDocs[$n++] = null !== $item ? signDocs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }

        return $model;
    }
}
