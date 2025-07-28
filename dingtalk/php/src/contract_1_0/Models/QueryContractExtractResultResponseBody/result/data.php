<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractExtractResultResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractExtractResultResponseBody\result\data\extractEntities;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var extractEntities[]
     */
    public $extractEntities;

    /**
     * @var string
     */
    public $extractStatus;
    protected $_name = [
        'extractEntities' => 'extractEntities',
        'extractStatus' => 'extractStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extractEntities) {
            $res['extractEntities'] = [];
            if (null !== $this->extractEntities && \is_array($this->extractEntities)) {
                $n = 0;
                foreach ($this->extractEntities as $item) {
                    $res['extractEntities'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->extractStatus) {
            $res['extractStatus'] = $this->extractStatus;
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
        if (isset($map['extractEntities'])) {
            if (!empty($map['extractEntities'])) {
                $model->extractEntities = [];
                $n = 0;
                foreach ($map['extractEntities'] as $item) {
                    $model->extractEntities[$n++] = null !== $item ? extractEntities::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['extractStatus'])) {
            $model->extractStatus = $map['extractStatus'];
        }

        return $model;
    }
}
