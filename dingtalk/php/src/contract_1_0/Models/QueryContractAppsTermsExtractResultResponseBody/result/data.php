<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsTermsExtractResultResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsTermsExtractResultResponseBody\result\data\extractedContents;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var extractedContents[]
     */
    public $extractedContents;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'extractedContents' => 'extractedContents',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extractedContents) {
            $res['extractedContents'] = [];
            if (null !== $this->extractedContents && \is_array($this->extractedContents)) {
                $n = 0;
                foreach ($this->extractedContents as $item) {
                    $res['extractedContents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['extractedContents'])) {
            if (!empty($map['extractedContents'])) {
                $model->extractedContents = [];
                $n = 0;
                foreach ($map['extractedContents'] as $item) {
                    $model->extractedContents[$n++] = null !== $item ? extractedContents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
