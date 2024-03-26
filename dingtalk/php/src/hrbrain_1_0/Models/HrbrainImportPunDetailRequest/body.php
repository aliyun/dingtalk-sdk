<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPunDetailRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $comment;

    /**
     * @var string
     */
    public $effectiveDate;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $punName;

    /**
     * @var string
     */
    public $punOrg;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'comment'       => 'comment',
        'effectiveDate' => 'effectiveDate',
        'extendInfo'    => 'extendInfo',
        'name'          => 'name',
        'punName'       => 'punName',
        'punOrg'        => 'punOrg',
        'workNo'        => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->comment) {
            $res['comment'] = $this->comment;
        }
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->punName) {
            $res['punName'] = $this->punName;
        }
        if (null !== $this->punOrg) {
            $res['punOrg'] = $this->punOrg;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['comment'])) {
            $model->comment = $map['comment'];
        }
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['punName'])) {
            $model->punName = $map['punName'];
        }
        if (isset($map['punOrg'])) {
            $model->punOrg = $map['punOrg'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
