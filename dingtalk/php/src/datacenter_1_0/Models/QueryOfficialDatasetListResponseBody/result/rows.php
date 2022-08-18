<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListResponseBody\result;

use AlibabaCloud\Tea\Model;

class rows extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $dsId;
    protected $_name = [
        'displayName' => 'displayName',
        'dsId'        => 'dsId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->dsId) {
            $res['dsId'] = $this->dsId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rows
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['dsId'])) {
            $model->dsId = $map['dsId'];
        }

        return $model;
    }
}
